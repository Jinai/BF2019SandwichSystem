using OnlineServices.Shared.FacilityServices.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer
{
    public class Report
    {
        public int Id { get; set; }
        public Component Component { get; set; }
        public Issue Issue { get; set; }
        public Room Room { get; set; }
        public string Comment { get; set; }
        public ReportStatus Status { get; set; }
    }
}
