using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;

namespace FacilityServices.BusinessLayer
{
    public class Component
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }

        public Component (MultiLanguageString name)
        {
            this.Name = name;
        }

    }
}
