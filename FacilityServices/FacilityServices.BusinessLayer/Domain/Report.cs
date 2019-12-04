using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer
{
    public class Report
    {
        public Object Object { get; set; }
        public BreakType Break { get; set; }
        public Floor Floor { get; set; }
        public Room Romm { get; set; }
        public string Comment { get; set; }
    }
}
