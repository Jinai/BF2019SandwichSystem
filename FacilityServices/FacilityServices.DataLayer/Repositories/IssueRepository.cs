using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;

namespace FacilityServices.DataLayer.Repositories
{
    public class IssueRepository : IIssueRepository
    {
        private FacilityContext facilityContext;

        public IssueRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public IssueTO Add(IssueTO Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IssueTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IssueTO GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IssueTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public IssueTO Update(IssueTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}