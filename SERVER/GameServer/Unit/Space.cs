﻿using Common.Proto.Space;
using GameServer.Db;
using GameServer.Manager;
using GameServer.Tool;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Unit
{
    public class Space
    {
        const int InvalidSpaceId = 0;

        public readonly int SpaceId;
        public readonly string Name;
        public readonly string Description = "";
        public readonly int Music = 0;

        public CharacterManager CharacterManager;
        public MonsterManager MonsterManager;

        public Space(int spaceId, string name)
        {
            SpaceId = spaceId;
            Name = name;

            CharacterManager = new(this);
            MonsterManager = new(this);
        }

        /// <summary>
        /// 角色进入场景
        /// </summary>
        public void EntityEnter(Entity entity)
        {
            Log.Information($"实体进入场景:{entity.EntityId}");
            var res = new EntityEnterResponse();
            res.EntityList.Add(entity.ToNetEntity());

            lock (CharacterManager.CharacterDict)
            {
                // 向所有角色广播新实体加入场景
                foreach (var character in CharacterManager.CharacterDict.Values)
                {
                    character.Player.Channel.Send(res, null);
                }

                // 如果新实体是角色，
                // 向新角色投递已在场景中的所有玩家
                if (entity.EntityType == EntityType.Character)
                {
                    res.EntityList.Clear();
                    foreach (var character in CharacterManager.CharacterDict.Values)
                    {
                        res.EntityList.Add(character.ToNetEntity());
                    }
                    var currentCharacter = entity as Character;
                    currentCharacter.Player.Channel.Send(res, null);
                }
            }
        }

        public void EntityLeave(Entity entity)
        {
            Log.Information($"实体离开场景:{entity.EntityId}");

            var res = new EntityLeaveResponse();
            res.EntityId = entity.EntityId;

            lock (CharacterManager.CharacterDict)
            {
                // 向所有角色广播新实体离开场景
                foreach (var character in CharacterManager.CharacterDict.Values)
                {
                    character.Player.Channel.Send(res, null);
                }
            }
        }

        public void EntityUpdate(Entity entity)
        {
            //entity.Position = res.EntitySync.Entity.Position.ToVector3();
            //entity.Direction = res.EntitySync.Entity.Direction.ToVector3();

            var res = new EntitySyncResponse() { EntitySync = new() };
            // res.EntitySync.Status = ;
            res.EntitySync.Entity = entity.ToNetEntity();

            lock (CharacterManager.CharacterDict)
            {
                // 向所有角色广播新实体的状态更新
                foreach (var character in CharacterManager.CharacterDict.Values)
                {
                    if (character.EntityId != entity.EntityId)
                    {
                        character.Player.Channel.Send(res, null);
                    }
                }
            }
        }
    }
}