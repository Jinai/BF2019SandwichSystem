using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class RoomTO : IEntity<int>
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public FloorTO Floor { get; set; }
        public IList<ComponentTypeTO> ComponentTypes { get; set; }
        public bool Archived { get; set; }
    }
}
