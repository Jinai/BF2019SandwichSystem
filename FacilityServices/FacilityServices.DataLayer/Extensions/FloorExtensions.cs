﻿using FacilityServices.DataLayer.Entities;
using OnlineServices.Shared.FacilityServices.Exceptions;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.DataLayer.Extensions
{
    public static class FloorExtensions
    {
        public static FloorTO ToTranfertObject(this FloorEF Floor)
        {
            if (Floor is null)
                throw new NotExistingFloorException(nameof(Floor));

            return new FloorTO
            {
                Id = Floor.Id,
                Name = Floor.Name,
            };
        }

        public static FloorEF ToEF(this FloorTO Floor)
        {
            if (Floor is null)
                throw new NotExistingFloorException(nameof(Floor));

            return new FloorEF()
            {
                Id = Floor.Id,
                Name = Floor.Name,
            };
        }
    }
}
