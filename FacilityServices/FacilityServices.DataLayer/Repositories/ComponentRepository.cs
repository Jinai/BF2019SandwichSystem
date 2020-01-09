using FacilityServices.DataLayer.Extensions;
using Microsoft.EntityFrameworkCore;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.DataLayer.Repositories
{
    public class ComponentRepository : IComponentRepository
    {
        private FacilityContext facilityContext;

        public ComponentRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public ComponentTO Add(ComponentTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var componentEF = entity.ToEF();
            componentEF.Room = facilityContext.Rooms.Include(x => x.Floor).First(x => x.Id == entity.Room.Id);

            return facilityContext.Components.Add(componentEF).Entity.ToTransfertObject();
        }

        public IEnumerable<ComponentTO> GetAll()
        {
            return facilityContext.Components.AsNoTracking().Include(x => x.Room).ThenInclude(x => x.Floor).Select(x => x.ToTransfertObject()).ToList();
        }

        public ComponentTO GetByID(int id)
        {
            return facilityContext.Components.AsNoTracking().Include(x => x.Room).ThenInclude(x => x.Floor).FirstOrDefault(x => x.Id == id).ToTransfertObject();
        }

        public bool Remove(ComponentTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.Id);
        }

        public bool Remove(int id)
        {
            var ReturnValue = false;
            if (!facilityContext.Components.Any(x => x.Id == id))
                throw new Exception($"ComponentRepository. Delete(ComponentId = {id}) no record to delete.");

            var component = facilityContext.Components.FirstOrDefault(x => x.Id == id);
            if (component != default)
            {
                try
                {
                    facilityContext.Components.Remove(component);
                    ReturnValue = true;
                }
                catch (Exception)
                {
                    ReturnValue = false;
                }
            }

            return ReturnValue;
        }

        public ComponentTO Update(ComponentTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (!facilityContext.Components.Any(x => x.Id == entity.Id))
                throw new Exception($"ComponentRepository. Update(ComponentTO) no record to update.");

            var attachedComponent = facilityContext.Components
                .Include(x => x.Room)
                .ThenInclude(x => x.Floor)
                .FirstOrDefault(x => x.Id == entity.Id);

            if (attachedComponent != default)
            {
                attachedComponent.UpdateFromDetached(entity.ToEF());
            }

            return facilityContext.Components.Update(attachedComponent).Entity.ToTransfertObject();
        }

        public List<ComponentTO> GetComponentByRoom(RoomTO room)
        {
            if (room is null)
            {
                throw new ArgumentNullException(nameof(room));
            }

            return facilityContext.Components.AsNoTracking().Where(x => x.Room.Id == room.Id).Select(x => x.ToTransfertObject()).ToList();
        }
    }
}