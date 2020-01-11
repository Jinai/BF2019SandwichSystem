using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.ComponentRepositoryTests
{
    [TestClass]
    public class UpdateComponentsTests
    {
        [TestMethod]
        public void UpdateComponent_AddAComponentAndChangeItsName_ReturnsUpdatedComponent()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                //// Arrange
                //IComponentRepository componentRepository = new ComponentRepository(memoryCtx);
                //IRoomRepository roomRepository = new RoomRepository(memoryCtx);
                //IFloorRepository floorRepository = new FloorRepository(memoryCtx);

                //var floor = new FloorTO { Number = 2 };
                //var addedFloor = floorRepository.Add(floor);
                //memoryCtx.SaveChanges();
                //var room = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = addedFloor };
                //var addedRoom = roomRepository.Add(room);
                //memoryCtx.SaveChanges();
                //var component = new ComponentTO { Name = new MultiLanguageString("Comp1", "Comp1", "Comp1"), Room = addedRoom };
                //var addedComponent = componentRepository.Add(component);
                //memoryCtx.SaveChanges();

                //// Act
                //addedComponent.Name = new MultiLanguageString("New Room1", "New Room1", "New Room1");
                //var updated = componentRepository.Update(addedComponent);

                //// Assert
                //Assert.AreEqual("New Room1", updated.Name.English);
            }
        }

        [TestMethod]
        public void UpdateComponent_ShouldThrowException_WhenNullIsSupplied()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                // Arrange
                //ComponentTO component = null;
                //var componentRepository = new ComponentRepository(memoryCtx);

                // Act & Assert
                //Assert.ThrowsException<ArgumentNullException>(() => componentRepository.Update(component));
            }
        }
    }
}
