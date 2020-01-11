using FacilityServices.DataLayer.Entities;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using OnlineServices.Common.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.DataLayer.Extensions
{
    public static class IncidentExtensions
    {
        public static IncidentTO ToTransfertObject(this IncidentEF Incident)
        {
            if (Incident is null)
                throw new ArgumentNullException(nameof(Incident));

            return new IncidentTO
            {
                Id = Incident.Id,
                Issue = Incident.Issue.ToTransfertObject(),
                Status = Incident.Status,
                SubmitDate = Incident.SubmitDate,
                Description = Incident.Description,
                // TODO RoomComponent = Incident.RoomComponent,
                UserId = Incident.UserId
            };
        }

        public static IncidentEF ToEF(this IncidentTO Incident)
        {
            if (Incident is null)
                throw new ArgumentNullException(nameof(Incident));

            return new IncidentEF
            {
                Id = Incident.Id,
                Issue = Incident.Issue.ToEF(),
                Status = Incident.Status,
                SubmitDate = Incident.SubmitDate,
                Description = Incident.Description,
                // TODO RoomComponent = Incident.RoomComponent,
                UserId = Incident.UserId
            };
        }
    }
}
