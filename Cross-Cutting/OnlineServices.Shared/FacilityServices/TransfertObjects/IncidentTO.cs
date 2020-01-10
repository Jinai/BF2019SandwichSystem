using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.Enumerations;
using System;
using System.Collections.Generic;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class IncidentTO : IEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ComponentTO Component { get; set; }
        public IssueTO Issue { get; set; }
        public List<CommentTO> AssistantComments { get; set; } = new List<CommentTO>();
        public string Description { get; set; }
        public DateTime SubmitDate { get; set; }
        public IncidentStatus Status { get; set; }
    }

}
