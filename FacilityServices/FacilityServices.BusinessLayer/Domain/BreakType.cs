using FacilityServices.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer
{
    public class BreakType
    {
        public int Id { get; set; }
        public StringTranslated Name { get; set; }
        public string Description { get; set; }
    }
}
