using OnlineServices.Shared.TranslationServices.TransfertObjects;

namespace FacilityServices.BusinessLayer
{
    public class Issue
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        
        public Issue(MultiLanguageString name)
        {
            this.Name = name;
        }
    }
}
