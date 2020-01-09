using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;

namespace FacilityServices.DataLayer.Repositories
{
    public class IncidentRepository : IIncidentRepository
    {
        private FacilityContext facilityContext;

        public IncidentRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public IncidentTO Add(IncidentTO Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncidentTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IncidentTO GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public List<IncidentTO> GetIncidentsByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IncidentTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public IncidentTO Update(IncidentTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}