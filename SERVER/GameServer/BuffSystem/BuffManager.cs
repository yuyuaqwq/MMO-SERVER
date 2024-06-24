﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.EntitySystem;
using GameServer.Manager;

namespace GameServer.BuffSystem
{
    public class BuffManager
    {
        private Dictionary<int, List<Buff>> _buffDict = new();

        public Actor OwnerActor {get; private set; }

        public BuffManager(Actor ownerActor)
        {
            OwnerActor = ownerActor;
        }

        public void Start()
        {

        }

        public void Update()
        {
            foreach (var list in _buffDict.Values)
            {
                foreach (var buff in list)
                {
                    buff.Update();
                }
            }
        }

        public void AddBuff(int buffId, Actor? caster = null)
        {
            if (!DataManager.Instance.BuffDict.TryGetValue(buffId, out var buffDefine)) return;
            
            if (!_buffDict.TryGetValue(buffId, out var buffList))
            {
                buffList = new List<Buff>();
                _buffDict[buffId] = buffList;
            }

            if (buffDefine.Type == "Attribute")
            {
                var buff = new AttributeBuff(buffId, this, caster, buffDefine.Duration, buffDefine.Modifier);
                buffList.Add(buff);
                buff.Start();
                if (Math.Abs(buffDefine.Duration) <= 1e-6) RemoveBuff(buff);
            }
        }

        public void RemoveBuff(Buff buff)
        {
            if (!_buffDict.TryGetValue(buff.BuffId, out var buffList)) return;
            buff.Exit();
            buffList.Remove(buff);
        }
    }
}
