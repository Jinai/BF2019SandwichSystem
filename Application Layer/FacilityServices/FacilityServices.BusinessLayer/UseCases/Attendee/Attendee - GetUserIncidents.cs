using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole
    {
        public List<IncidentTO> GetUserIncidents(int userId)
        {
            if (userId <= 0)
                throw new LoggedException("Bad userId.");

            // Todo check unique constraints, check if room + componenttype exists, etc.
            var incidents = unitOfWork.IncidentRepository.GetIncidentsByUserId(userId);
            return incidents.ToList();
        }
    }
}
