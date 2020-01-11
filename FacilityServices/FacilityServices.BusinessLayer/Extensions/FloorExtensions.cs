using FacilityServices.BusinessLayer.Domain;
﻿using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class FloorExtensions
    {
        public static Floor ToDomain(this FloorTO FloorTO)
        {
            return new Floor()
            {
                Id = FloorTO.Id,
                Number = FloorTO.Number
            };
        }
        public static FloorTO ToTransfertObject(this Floor Floor)
        {
            return new FloorTO()
            {
                Id = Floor.Id,
                Number = Floor.Number,
            };
        }
    }
}
