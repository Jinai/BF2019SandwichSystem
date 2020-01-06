using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class RoomTO
    {
        public string Name { get; set; }
        public FloorTO FloorAttached { get; set; }
    }
}
