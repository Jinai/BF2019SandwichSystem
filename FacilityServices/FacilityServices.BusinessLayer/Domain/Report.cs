using OnlineServices.Shared.FacilityServices.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer
{
    public class Report
    {
        public Component Object { get; set; }
        public Issue Break { get; set; }
        public Room Room { get; set; }
        public string Comment { get; set; }
        public ReportStatus Status { get; set; }
    }
}
