using OnlineServices.Shared.DataAccessHelpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Comments")]
    public class CommentEF : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        // TODO : User from UserServices
        //public IUser User { get; set; }
        public IncidentEF Incident { get; set; }
        public string Message { get; set; }
        public DateTime SubmitDate { get; set; }
    }
}
