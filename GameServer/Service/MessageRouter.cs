﻿using Common.Network;
using Common.Proto;
using Common.Tool;
using GameServer.Tool;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Service
{
    public class MessageRouter : Singleton<MessageRouter>
    {
        public delegate void MessageHandler<TMessage>(object? sender, TMessage msg) where TMessage : Google.Protobuf.IMessage;

        //private record SessionPacket(Connection Connection, BytesPacket Packet);

        //private Queue<SessionPacket> _pendingDispatchQueue = new();
        private Dictionary<Type, Delegate?> _messageHandlers = new();

        private MethodInfo DispatchToHandlerMethod { get; init; }

        public MessageRouter() : base()
        {
            var method = GetType().GetMethod("DispatchToHandler",
                BindingFlags.NonPublic | BindingFlags.Instance).AssertNotNull();
            DispatchToHandlerMethod = method;
        }

        public void Reigster<TMessage>(MessageHandler<TMessage> handler) where TMessage: Google.Protobuf.IMessage
        {
            var type = typeof(TMessage);
            if (!_messageHandlers.ContainsKey(type))
                _messageHandlers.Add(type, null);
            _messageHandlers[type] = (_messageHandlers[type] as MessageHandler<TMessage>) + handler;
        }
        public void UnReigster<TMessage>(MessageHandler<TMessage> handler) where TMessage : Google.Protobuf.IMessage
        {
            var type = typeof(TMessage);
            Debug.Assert(_messageHandlers.ContainsKey(type));
            _messageHandlers[type] = (_messageHandlers[type] as MessageHandler<TMessage>) - handler;
        }

        public void DispatchMessage(object? sender, NetMessage msg)
        {
            Debug.Assert(Alogrithm.IsUniqueNull(msg.Request, msg.Response));

            Task.Run(() =>
            {
                var realyMsg = msg.Request != null ? msg.Request : msg.Response as Google.Protobuf.IMessage;
                foreach (var property in realyMsg.GetType().GetProperties())
                {
                    var propertyType = property.GetType();
                    if (typeof(Google.Protobuf.IMessage).IsAssignableFrom(propertyType))
                    {
                        var propertyValue = property.GetValue(realyMsg).AssertNotNull();
                        var method = DispatchToHandlerMethod.MakeGenericMethod(propertyValue.GetType()).AssertNotNull();
                        method.Invoke(this, new object[] { sender,  propertyValue });
                    }
                }
            });
        }

        private void DispatchToHandler<TMessage>(object? sender, TMessage msg) where TMessage : Google.Protobuf.IMessage
        {
            var type = typeof(TMessage);
            if (_messageHandlers.ContainsKey(type))
            {
                var handler = _messageHandlers[type] as MessageHandler<TMessage>;
                try
                {
                    handler?.Invoke(sender, msg);
                }
                catch (Exception ex)
                {
                    Global.Logger.Error(ex);
                    //TODO 异常处理
                }
            }
        }
    }
}
