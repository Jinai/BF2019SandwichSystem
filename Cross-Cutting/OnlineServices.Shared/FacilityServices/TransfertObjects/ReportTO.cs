using System;
using System.Diagnostics.CodeAnalysis;
using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.Enumerations;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class ReportTO
    {
        public ComponentTO Component { get; set; }
        public IssueTO Issue { get; set; }
        public RoomTO Romm { get; set; }
        public string Comment { get; set; }
        public ReportStatus Status { get; set; }
    }

}
