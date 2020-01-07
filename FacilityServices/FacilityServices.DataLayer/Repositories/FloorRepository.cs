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
        => Remove(entity.Id);


        public bool Remove(int Id)
        {
            var ReturnValue = false;
            if (!facilityContext.Rooms.Any(x => x.Id == Id))
                throw new Exception($"FloorRepository. Delete(FloorId = {Id}) no record to delete.");

            var floor = facilityContext.Rooms.FirstOrDefault(x => x.Id == Id);
            if (floor != default)
            {
                try
                {
                    facilityContext.Rooms.Remove(floor);
                    ReturnValue = true;
                }
                catch (Exception)
                {
                    ReturnValue = false;
                }
            }

            return ReturnValue;
        }

        public FloorTO Update(FloorTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}