using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class IssueTO
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public string Description { get; set; }
    }
}
