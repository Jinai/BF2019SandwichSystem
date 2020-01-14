﻿using OnlineServices.Common.DataAccessHelpers;
using OnlineServices.Common.TranslationServices.TransfertObjects;

namespace OnlineServices.Common.FacilityServices.TransfertObjects
{
    public class ComponentTypeTO : IEntity<int>
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public bool Archived { get; set; }
        //public List<IssueTO> Issues { get; set; } = new List<IssueTO>();
        //public List<RoomTO> Rooms { get; set; } = new List<RoomTO>();
    }
}
