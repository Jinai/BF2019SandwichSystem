using OnlineServices.Shared.TranslationServices.TransfertObjects;

namespace FacilityServices.BusinessLayer
{
    public class Issue
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public string Description { get; set; }
    }
}
