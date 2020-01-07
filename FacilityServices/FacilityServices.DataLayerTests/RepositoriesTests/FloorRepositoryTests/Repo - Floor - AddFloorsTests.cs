using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Linq;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.FloorRepositoryTests
{
    [TestClass]
    public class AddFloorsTests
    {
        [TestMethod()]
        public void AddFloor_ThrowsException_WhenANonExistingIdIsProvided()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                //ARRANGE
                var FloorToUseInTest = new FloorTO
                {
                    Id = 1,
                    Name = -1
                };

                var floorRepository = new FloorRepository(memoryCtx);

                //ASSERT
                Assert.ThrowsException<ArgumentNullException>(() => floorRepository.Add(null));
               
            }
        }
        [TestMethod()]
        public void AddFloor_Successfull()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                //ARRANGE
                var FloorToUseInTest = new FloorTO
                {
                    Id = 1,
                    Name = 0
                };

                var floorRepository = new FloorRepository(memoryCtx);

                //ACT
                floorRepository.Add(FloorToUseInTest);
                memoryCtx.SaveChanges();

                //ASSERT
                Assert.AreEqual(1, floorRepository.GetAll().Count());
                var FloorToAssert = floorRepository.GetByID(1);
                Assert.AreEqual(1, FloorToAssert.Id);
                Assert.AreEqual(0, FloorToAssert.Name);
            }
        }
    }
}
