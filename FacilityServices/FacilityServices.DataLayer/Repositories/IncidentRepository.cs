using FacilityServices.DataLayer.Extensions;
using Microsoft.EntityFrameworkCore;
using OnlineServices.Common.FacilityServices.Interfaces.Repositories;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (Entity is null)
                throw new ArgumentNullException(nameof(Entity));

            var incident = Entity.ToEF();
            incident.Issue = facilityContext.Issues.First(x => x.Id == Entity.Issue.Id);

            return facilityContext.Incidents.Add(incident).Entity.ToTransfertObject();
        }

        public IEnumerable<IncidentTO> GetAll()
        {
            return facilityContext.Incidents
                                  .Include(i => i.Issue)
                                  //.Include(i => i.RommComponent)
                                  //.ThenInclude(comp => comp.Room)
                                  //.ThenInclude(r => r.Floor)
                                  //.Include(i => i.Component.ComponentType)
                                  .Select(i => i.ToTransfertObject());
        }

        public IncidentTO GetById(int Id)
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