using OnlineServices.Shared.TranslationServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.Domain
{
    public class Component
    {
        public int Id { get; set; }
        public ComponentType ComponentType { get; set; }
        public Room Room { get; set; }
        public MultiLanguageString Name { get; set; }
        public bool Archived { get; set; }

        public Component (MultiLanguageString name)
        {
            this.Name = name;
        }

    }
}
