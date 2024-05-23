using Common.Network;
using Common.Tool;
using Google.Protobuf;
using QFramework;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using MMORPG.Game;
using MMORPG.Tool;
using PimDeWitte.UnityMainThreadDispatcher;
using UnityEngine;
using static MMORPG.System.INetworkSystem;

namespace MMORPG.System
{
    public interface INetworkSystem : ISystem
    {
        public delegate void ReceivedEventLikeEventHandler<in TMessage>(TMessage response) where TMessage : class, IMessage;

        public IUnRegister ReceiveEventLike<TMessage>(ReceivedEventLikeEventHandler<TMessage> onReceived) where TMessage : class, IMessage;
        public IUnRegister ReceiveEventLikeInUnityThread<TMessage>(ReceivedEventLikeEventHandler<TMessage> onReceived) where TMessage : class, IMessage;

        public Task ConnectAsync();
        public void Close();

        public void SendToServer(IMessage msg);
        public Task<T> ReceiveAsync<T>() where T : class, IMessage;
        public Task StartAsync();
    }

    public class NetworkSystem : AbstractSystem, INetworkSystem
    {
        private NetSession _session;
        private Dictionary<Type, Delegate> _eventLikeMessageHandlers = new();

        ////TODO 高水位处理
        private LinkedList<IMessage> _messageList = new();

        public async Task<T> ReceiveAsync<T>() where T : class, IMessage
        {
            while (true)
            {
                IMessage msg = null;
                lock (_messageList)
                {
                    var node = _messageList.FindIf(msg => { return msg.GetType() == typeof(T); });
                    if (node != null)
                    {
                        msg = node.Value;
                        //UnityEngine.Debug.Log(typeof(T));
                        _messageList.Remove(node);
                    }
                }
                if (msg == null)
                {
                    await Task.Delay(100);
                    continue;
                }
                var res = msg as T;
                Debug.Assert(res != null);
                return res;
            }
        }

        public void SendToServer(IMessage msg)
        {
            _session.Send(msg);
        }

        public Task StartAsync()
        {
            _session.PacketReceived += OnPacketReceived;
            return _session.StartAsync();
        }

        private void OnPacketReceived(object sender, PacketReceivedEventArgs e)
        {
            var msgType = e.Packet.Message.GetType();
            if (ProtoManager.IsEventLike(msgType))
            {
                _eventLikeMessageHandlers[msgType]?.DynamicInvoke(new object[] { e.Packet.Message });
            }
            else
            {
                _messageList.AddLast(e.Packet.Message);
            }
        }

        public async Task ConnectAsync()
        {
            Socket socket;
            var box = this.GetSystem<IBoxSystem>();
            while (true)
            {
                // 显示旋转加载框
                box.ShowSpinner("连接服务器中......");
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    await socket.ConnectAsync(NetConfig.ServerIpAddress, NetConfig.ServerPort);
                    box.CloseSpinner();
                    break;
                }
                catch (Exception ex)
                {
                    Tool.Log.Error("Network", ex, $"连接服务器时出现错误:{ex.Message}");
                    box.CloseSpinner();
                    await box.ShowMessageAsync("错误", $"连接服务器失败:{ex}", "重新连接");
                    continue;
                }
            }
            _session = new NetSession(socket);
        }

        protected override void OnInit()
        {
            this.RegisterEvent<ApplicationQuitEvent>(OnApplicationQuit);
        }

        private void OnApplicationQuit(ApplicationQuitEvent e)
        {
            Close();
        }

        public IUnRegister ReceiveEventLike<TMessage>(ReceivedEventLikeEventHandler<TMessage> onReceived) where TMessage : class, IMessage
        {
            var type = typeof(TMessage);
            _eventLikeMessageHandlers.TryAdd(type, null);
            _eventLikeMessageHandlers[type] = (_eventLikeMessageHandlers[type] as ReceivedEventLikeEventHandler<TMessage>) + onReceived;
            return new CustomUnRegister(() => UnReceiveEvent(onReceived));
        }

        public IUnRegister ReceiveEventLikeInUnityThread<TMessage>(ReceivedEventLikeEventHandler<TMessage> onReceived) where TMessage : class, IMessage
        {
            return ReceiveEventLike<TMessage>(x =>
                UnityMainThreadDispatcher.Instance().Enqueue(() => onReceived(x))
            );
        }

        private void UnReceiveEvent<TMessage>(ReceivedEventLikeEventHandler<TMessage> onReceived) where TMessage : class, IMessage
        {
            var type = typeof(TMessage);
            Debug.Assert(_eventLikeMessageHandlers.ContainsKey(type));
            _eventLikeMessageHandlers[type] = (_eventLikeMessageHandlers[type] as ReceivedEventLikeEventHandler<TMessage>) - onReceived;
        }

        public void Close()
        {
            _session.Close();
        }
    }
}
