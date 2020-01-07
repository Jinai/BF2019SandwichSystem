using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;

namespace FacilityServices.DataLayer.Repositories
{
    public class FloorRepository : IFloorRepository
    {
        private FacilityContext facilityContext;

        public FloorRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public FloorTO Add(FloorTO Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FloorTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public FloorTO GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(FloorTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public FloorTO Update(FloorTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}