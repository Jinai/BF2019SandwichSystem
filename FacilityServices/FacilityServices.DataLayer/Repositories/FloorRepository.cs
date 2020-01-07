using FacilityServices.DataLayer.Extensions;
using Microsoft.EntityFrameworkCore;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.DataLayer.Repositories
{
    public class FloorRepository : IFloorRepository
    {
        private readonly FacilityContext facilityContext;

        public FloorRepository(FacilityContext ContextIoC)
        {
            this.facilityContext = ContextIoC ?? throw new ArgumentNullException($"{nameof(ContextIoC)} in IngredientRepository");
        }

        public FloorTO Add(FloorTO Entity)
        {
            if (Entity is null)
                throw new ArgumentNullException(nameof(Entity));

            return facilityContext.Floors
                .Add(Entity.ToEF())
                .Entity
                .ToTransfertObject();
        }

        public IEnumerable<FloorTO> GetAll()
        => facilityContext.Floors
            .Select(x => x.ToTransfertObject())
            .ToList();

        public FloorTO GetByID(int Id)
        {
            return facilityContext.Floors
            .FirstOrDefault(x => x.Id == Id)
            .ToTransfertObject();
        }

        public bool Remove(FloorTO entity)
        {
            try
            {
                facilityContext.Floors.Remove(entity.ToEF());
                return true;
            }
            catch (Exception Ex)
            {
                throw;
            }
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