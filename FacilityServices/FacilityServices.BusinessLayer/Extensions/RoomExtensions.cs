﻿using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class RoomExtensions
    {
        public static Room ToDomain(this RoomTO RoomTO)
        {
            return new Room(RoomTO.Name, RoomTO.FloorAttached.ToDomain())
            {
                Id = RoomTO.Id
            };
        }


        //public static RoomTO ToTransfertObject(this Room Room)
        //{

        //}
        //public static RoomTO ToTransfertObject(this Room Room, Floor Floor)
        //{

        //}
    }
}