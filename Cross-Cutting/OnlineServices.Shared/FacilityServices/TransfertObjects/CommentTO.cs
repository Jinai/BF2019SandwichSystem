using OnlineServices.Shared.DataAccessHelpers;
using System;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class CommentTO : IEntity<int>
    {
        public int Id { get; set; }
        // TODO : User from UserServices
        //public IUser User { get; set; }
        public IncidentTO Incident { get; set; }
        public string Message { get; set; }
        public DateTime SubmitDate { get; set; }
    }
}
