using OnlineServices.Shared.TranslationServices.TransfertObjects;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class ComponentTO
    {
        public int Id { get; set; }
        public RoomTO Room { get; set; }
        public MultiLanguageString Name { get; set; }
    }
}
