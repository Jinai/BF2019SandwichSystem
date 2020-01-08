using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace FacilityServices.DataLayer.Repositories
{
    public class ComponentTypeRepository : IComponentTypeRepository
    {
        private FacilityContext facilityContext;

        public ComponentTypeRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public ComponentTypeTO Add(ComponentTypeTO Entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ComponentTypeTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ComponentTypeTO GetByID(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(ComponentTypeTO entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public ComponentTypeTO Update(ComponentTypeTO Entity)
        {
            throw new System.NotImplementedException();
        }
    }
}