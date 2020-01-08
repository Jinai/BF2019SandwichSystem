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
    public class AddRoomTest
    {
        [TestMethod]
        public void Add_ReturnRoomTONotNull()
        {
            //ARRANGE
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using var context = new FacilityContext(options);
            IRoomRepository repository = new RoomRepository(context);
            RoomTO room = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1" ), Floor = new FloorTO { Id = 1, Number = 1 } };
            //ACT
            var result = repository.Add(room);
            context.SaveChanges();
            //ASSERT
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Name.French, "Room1");
        }
    }
}
