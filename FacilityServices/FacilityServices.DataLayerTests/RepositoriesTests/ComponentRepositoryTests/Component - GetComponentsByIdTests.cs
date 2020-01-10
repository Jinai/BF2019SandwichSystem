using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Linq;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.ComponentRepositoryTest
{
    [TestClass]
    public class GetComponentsTests
    {
        [TestMethod]
        public void GetComponentById_ThrowsException_WhenInvalidIdIsProvided()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                var componentRepository = new ComponentRepository(memoryCtx);

                Assert.ThrowsException<ArgumentNullException>(() => componentRepository.GetByID(100));
            }
        }

        [TestMethod]
        public void GetComponentById_AddNewComponentAndRetrieveIt_ReturnsTheCorrectComponent()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                IComponentRepository componentRepository = new ComponentRepository(memoryCtx);
                IRoomRepository roomRepository = new RoomRepository(memoryCtx);
                IFloorRepository floorRepository = new FloorRepository(memoryCtx);

                var floor = new FloorTO { Number = 2 };
                var addedFloor = floorRepository.Add(floor);
                memoryCtx.SaveChanges();
                var room = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = addedFloor };
                var addedRoom = roomRepository.Add(room);
                memoryCtx.SaveChanges();
                var component = new ComponentTO { Name = new MultiLanguageString("Comp1", "Comp1", "Comp1"), Room = addedRoom};
                var addedComponent = componentRepository.Add(component);
                memoryCtx.SaveChanges();

                var retrievedComponent = componentRepository.GetByID(addedComponent.Id);

                Assert.IsNotNull(retrievedComponent);
                Assert.AreEqual(addedComponent.Id, retrievedComponent.Id);
            }
        }
    }
}
