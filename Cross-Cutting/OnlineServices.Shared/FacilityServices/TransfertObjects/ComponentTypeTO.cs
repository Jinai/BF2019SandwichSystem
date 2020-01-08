using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class ComponentTypeTO : IEntity<int>
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public bool Archived { get; set; }
        public List<IssueTO> Issues { get; set; } = new List<IssueTO>();
    }
}
