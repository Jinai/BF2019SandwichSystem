using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FacilityServices.DataLayerTests.RepositoriesTests.ComponentRepositoryTest
{
    [TestClass]
    public class AddComponentsTests
    {
        [TestMethod]
        public void AddComponent_ShouldInsertInDb_WhenValidComponentIsSupplied()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                // Arrange
                IComponentRepository componentRepository = new ComponentRepository(memoryCtx);
                IRoomRepository roomRepository = new RoomRepository(memoryCtx);
                IFloorRepository floorRepository = new FloorRepository(memoryCtx);

                var floor = new FloorTO { Number = 2 };
                var addedFloor = floorRepository.Add(floor);
                memoryCtx.SaveChanges();
                var room = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = addedFloor };
                var addedRoom = roomRepository.Add(room);
                memoryCtx.SaveChanges();
                var component = new ComponentTO { Name = new MultiLanguageString("Comp1", "Comp1", "Comp1"), Room = addedRoom };

                // Act
                var addedComponent = componentRepository.Add(component);
                memoryCtx.SaveChanges();

                // Assert
                Assert.IsNotNull(addedComponent);
                Assert.IsNotNull(addedComponent.Room);
                Assert.IsNotNull(addedComponent.Room.Floor);
                Assert.IsTrue(addedComponent.Id != 0);
                Assert.AreEqual(1, componentRepository.GetAll().Count());
            }
        }

        [TestMethod]
        public void AddComponent_ShouldThrowException_WhenNullIsSupplied()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                // Arrange
                ComponentTO component = null;
                var componentRepository = new ComponentRepository(memoryCtx);

                // Act & Assert
                Assert.ThrowsException<ArgumentNullException>(() => componentRepository.Add(component));
            }
        }
    }
}
