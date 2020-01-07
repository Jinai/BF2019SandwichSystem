using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.Linq;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.RoomRepositoryTest
{
    [TestClass]
    public class GetAllTest
    {
        [TestMethod]
        public void GetAll_AddThreeRooms_ReturnCorrectNumberOfRooms()
        {
            //ARRANGE
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using var context = new FacilityContext(options);
            IRoomRepository repository = new RoomRepository(context);
            RoomTO room1 = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = new FloorTO { Id = 1, Name = 1 } };
            RoomTO room2 = new RoomTO { Name = new MultiLanguageString("Room2", "Room2", "Room2"), Floor = new FloorTO { Id = 2, Name = 2 } };
            RoomTO room3 = new RoomTO { Name = new MultiLanguageString("Room3", "Room3", "Room3"), Floor = new FloorTO { Id = 3, Name = 1 } };
            repository.Add(room1);
            context.SaveChanges();
            repository.Add(room2);
            context.SaveChanges();
            repository.Add(room3);
            context.SaveChanges();
            //ACT
            var rooms = repository.GetAll();
            //ASSERT
            Assert.AreEqual(rooms.Count(), 3);
        }
    }
}
