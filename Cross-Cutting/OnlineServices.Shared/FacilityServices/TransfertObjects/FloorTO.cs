﻿using OnlineServices.Shared.DataAccessHelpers;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class FloorTO : IEntity<int>
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool Archived { get; set; }
    }
}
