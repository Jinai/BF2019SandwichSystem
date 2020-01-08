using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Shared.FacilityServices.Interfaces;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.Linq;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.RoomRepositoryTest
{
    [TestClass]
    public class GetRoomsByFloors
    {
        [TestMethod]
        [Ignore]
        public void GetRoomsByFloors_ReturnCoorectNumberOfCorrespondingRooms()
        {
            //ARRANGE
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using var context = new FacilityContext(options);
            IRoomRepository repository = new RoomRepository(context);
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            mockUnitOfWork.SetupSequence(u => u.FloorRepository.GetByID(It.IsAny<int>()))
                          .Returns(new FloorTO { Id = 1, Number = 1 });

            var gottenFloor = mockUnitOfWork.Object.FloorRepository.GetByID(1);

            RoomTO room1 = new RoomTO { Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = gottenFloor };
            RoomTO room2 = new RoomTO { Name = new MultiLanguageString("Room2", "Room2", "Room2"), Floor = new FloorTO { Id= 2, Number = 2 } };
            RoomTO room3 = new RoomTO { Name = new MultiLanguageString("Room3", "Room3", "Room3"), Floor = gottenFloor };
            //Save the Add() response in firstRoomAdded variable, in order to use its Floor later.
            var firstRoomAdded = repository.Add(room1);
            repository.Add(room2);
            repository.Add(room3);
            context.SaveChanges();
            //ACT
            var retrievedRooms = repository.GetRoomsByFloors(firstRoomAdded.Floor);
            //ASSERT
            Assert.IsNotNull(retrievedRooms);
            Assert.AreEqual(retrievedRooms.Count(), 2);
        }
    }
}