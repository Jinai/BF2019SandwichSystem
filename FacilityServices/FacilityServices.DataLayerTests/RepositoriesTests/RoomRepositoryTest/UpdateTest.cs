using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.RoomRepositoryTest
{
    [TestClass]
    public class UpdateTest
    {
        [TestMethod]
        public void UpdateTest_AddARoopmAndChangeItsName_ReturnUpdatedRoom()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using var context = new FacilityContext(options);
            IRoomRepository repository = new RoomRepository(context);
            IFloorRepository floorRepository = new FloorRepository(context);

            var floor = new FloorTO { Number = 2 };
            var addedFloor1 = floorRepository.Add(floor);
            context.SaveChanges();

            RoomTO room = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = addedFloor1};
            var added = repository.Add(room);
            context.SaveChanges();
            added.Name = new MultiLanguageString("New Room1", "New Room1", "New Room1");
            var updated = repository.Update(added);
            Assert.AreEqual(updated.Name.English, "New Room1");
        }
    }
}
