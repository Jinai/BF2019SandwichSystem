using FacilityServices.DataLayer.Entities;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System;

namespace FacilityServices.DataLayer.Extensions
{
    public static class RoomComponentTypeExtensions
    {
        public static RoomComponentTO ToTransfertObject(this RoomComponentEF roomComponent)
        {
            if (roomComponent is null)
                throw new ArgumentNullException("ToTransfertObject => The RoomComponent object can not be null");

            return new RoomComponentTO
            {
                ComponentTypeId = roomComponent.ComponentTypeId,
                RoomId = roomComponent.RoomId,
                ComponentType = roomComponent.ComponentType.ToTransfertObject(),
                Room = roomComponent.Room.ToTransfertObject()
            };
        }

        public static RoomComponentEF ToEF(this RoomComponentTO roomComponent)
        {
            if (roomComponent is null)
                throw new ArgumentNullException("ToEF => The RoomComponent object can not be null");

            return new RoomComponentEF
            {
                ComponentTypeId = roomComponent.ComponentTypeId,
                RoomId = roomComponent.RoomId,
                ComponentType = roomComponent.ComponentType.ToEF(),
                Room = roomComponent.Room.ToEF()
            };
        }
    }
}
