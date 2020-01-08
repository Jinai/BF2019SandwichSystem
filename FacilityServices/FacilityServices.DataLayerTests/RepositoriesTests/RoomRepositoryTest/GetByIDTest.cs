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
    public class GetByIDTest
    {
        [TestMethod]
        public void GetByID_AddNewRoomAndRetrieveTheAddedRoom_ReturnTheCoorectRoom()
        {
            //ARRANGE
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using var context = new FacilityContext(options);
            IRoomRepository repository = new RoomRepository(context);
            RoomTO room = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = new FloorTO { Id = 1, Number = 1 } };
            var result = repository.Add(room);
            context.SaveChanges();
            //ACT
            var retrievedRoom = repository.GetByID(result.Id);
            //ASSERT
            Assert.IsNotNull(retrievedRoom);
            Assert.AreEqual(retrievedRoom.ToString(), result.ToString());
        }
    }
}
