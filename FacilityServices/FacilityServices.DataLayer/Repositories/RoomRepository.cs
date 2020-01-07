using FacilityServices.DataLayer.Entities;
using FacilityServices.DataLayer.Extensions;
using Microsoft.EntityFrameworkCore;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.DataLayer.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private FacilityContext facilityContext;

        public RoomRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public RoomTO Add(RoomTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            return facilityContext.Rooms.Add(Entity.ToEF()).Entity.ToTranfertObject();
        }

        public IEnumerable<RoomTO> GetAll()
        {
            return facilityContext.Rooms
                                  .Include(r => r.Floor)
                                  .Select(r => r.ToTranfertObject());
        }

        public RoomTO GetByID(int Id)
        {
            return facilityContext.Rooms
                                  .AsNoTracking()
                                  .Include(r => r.Floor)
                                  .FirstOrDefault(r => r.Id == Id).ToTranfertObject();
        }

        public List<RoomTO> GetRoomsByFloors(FloorTO Floor)
        {
            return facilityContext.Rooms
                                  .Include(r => r.Floor)
                                  .Where(r => r.Floor.Id == Floor.Id)
                                  .Select(r => r.ToTranfertObject())
                                  .ToList();
        }

        public bool Remove(RoomTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var entityEF  = facilityContext.Rooms.Find(entity.Id);
            var tracking = facilityContext.Rooms.Remove(entityEF);
            return tracking.State == EntityState.Deleted;
        }

        public bool Remove(int Id)
        {
            return Remove(GetByID(Id));
        }

        public RoomTO Update(RoomTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var EFEntity = GetEFEntity<RoomEF>(Entity.Id);
            facilityContext.Entry(EFEntity).State = EntityState.Modified;

            return EFEntity.ToTranfertObject();
        }

        private T GetEFEntity<T>(int Id) where T : class
        {
            return facilityContext.Set<T>().Find(Id);
        }
    }
}