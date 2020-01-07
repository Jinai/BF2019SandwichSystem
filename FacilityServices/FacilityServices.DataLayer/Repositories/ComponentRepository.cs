using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;

namespace FacilityServices.DataLayer.Repositories
{
    public class ComponentRepository : IComponentRepository
    {
        private FacilityContext facilityContext;

        public ComponentRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public ComponentTO Add(ComponentTO Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComponentTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ComponentTO GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ComponentTO> GetComponentByRoom(RoomTO Room)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ComponentTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public ComponentTO Update(ComponentTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}