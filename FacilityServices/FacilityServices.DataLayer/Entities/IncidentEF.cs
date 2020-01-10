using OnlineServices.Common.DataAccessHelpers;
using OnlineServices.Common.FacilityServices.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Incidents")]
    public class IncidentEF : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public RoomComponentEF RoomComponent { get; set; }
        public IssueEF Issue { get; set; }
        //public List<CommentEF> Comments { get; set; } = new List<CommentEF>();
        public string Description { get; set; }
        public DateTime SubmitDate { get; set; }
        public IncidentStatus Status { get; set; }
    }
}