﻿using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Shared.FacilityServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class RoomExtensions
    {
        public static Room ToDomain(this RoomTO RoomTO)
        {
            return new Room(RoomTO.Name, RoomTO.Floor.ToDomain())
            {
                Id = RoomTO.Id
            };
        }

        public static RoomTO ToTransfertObject(this Room Room)
        {
            return new RoomTO
            {
                Id = Room.Id,
                Name = Room.Name,
                Floor = Room.Floor.ToTransfertObject()
            };
        }
    }
}
