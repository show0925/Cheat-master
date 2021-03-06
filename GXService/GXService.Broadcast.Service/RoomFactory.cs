﻿using System;
using System.Collections.Generic;
using System.Linq;
using GXService.Broadcast.Service.Models;

namespace GXService.Broadcast.Service
{
    public class RoomFactory<T> where T : RoomContext, new()
    {
        private readonly List<T> _roomContexts = new List<T>();

        public static RoomFactory<T> Singleton = new RoomFactory<T>();

        private RoomFactory()
        {}

        public T CreateRoom()
        {
            var c = typeof (T).GetConstructor(Type.EmptyTypes);
            if (c == null)
            {
                return null;
            }
            var roomContext = c.Invoke(null) as T;
            _roomContexts.Add(roomContext);

            return roomContext;
        }

        public T GetRoom(string roomId)
        {
            return _roomContexts.FirstOrDefault(r => r.RoomId == roomId);
        }

        public List<T> GetAllRoom()
        {
            return _roomContexts.ToList();
        }
    }
}
