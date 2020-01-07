using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FacilityServices.DataLayerTests.RepositoriesTests.FloorRepositoryTests
{
    [TestClass]
    public class RemoveFloorsTests
    {
        [TestMethod()]
        public void RemoveFloorByTranfertObject_ThrowException_WhenDeletingANonExistantFloor()
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

                var FloorToUseInTest2 = new FloorTO
                {
                    Id = 2,
                    Name = -1
                };
                var FloorToUseInTest3 = new FloorTO
                {
                    Id = 3,
                    Name = -2
                };


                var floorRepository = new FloorRepository(memoryCtx);

                //ACT
                floorRepository.Add(FloorToUseInTest);
                floorRepository.Add(FloorToUseInTest2);
                memoryCtx.SaveChanges();

                //ASSERT
                Assert.ThrowsException<Exception>(() => floorRepository.Remove(FloorToUseInTest3));
            }
        }
        [TestMethod()]
        public void RemoveFloorByTranfertObject_Successfull()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                   .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                   .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                //ARRANGE
                var FloorToUseInTest = new FloorTO
                {
                   //Id = 1,
                    Name = 0
                };

                var FloorToUseInTest2 = new FloorTO
                {
                   // Id = 2,
                    Name = -1
                };

                var floorRepository = new FloorRepository(memoryCtx);

                //ACT
                var f1 = floorRepository.Add(FloorToUseInTest);
                var f2 = floorRepository.Add(FloorToUseInTest2);
                memoryCtx.SaveChanges();
                floorRepository.Remove(f2);
                memoryCtx.SaveChanges();

                var retrievedFloors = floorRepository.GetAll();

                Assert.AreEqual(1, retrievedFloors.Count());
                Assert.IsFalse(retrievedFloors.Any(x => x.Id == 2));
            }

        }
        [TestMethod()]
        public void RemoveFloorById_ThrowException_WhenDeletingANonExistantFloor()
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

                var FloorToUseInTest2 = new FloorTO
                {
                    Id = 2,
                    Name = -1
                };
                var FloorToUseInTest3 = new FloorTO
                {
                    Id = 3,
                    Name = -2
                };


                var floorRepository = new FloorRepository(memoryCtx);

                //ACT
                floorRepository.Add(FloorToUseInTest);
                floorRepository.Add(FloorToUseInTest2);
                memoryCtx.SaveChanges();

                //ASSERT
                Assert.ThrowsException<Exception>(() => floorRepository.Remove(3));
            }
        }
        [TestMethod()]
        public void RemoveFloorById_Successfull()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                   .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                   .Options;

            using (var memoryCtx = new FacilityContext(options))
            {
                //ARRANGE
                var FloorToUseInTest = new FloorTO
                {
                    //Id = 1,
                    Name = 0
                };

                var FloorToUseInTest2 = new FloorTO
                {
                    //Id = 2,
                    Name = -1
                };
                var FloorToUseInTest3 = new FloorTO
                {
                    //Id = 3,
                    Name = -2
                };


                var floorRepository = new FloorRepository(memoryCtx);

                //ACT
                floorRepository.Add(FloorToUseInTest);
                floorRepository.Add(FloorToUseInTest2);
                memoryCtx.SaveChanges();
                floorRepository.Remove(1);
                memoryCtx.SaveChanges();

                var retrievedFloors = floorRepository.GetAll();

                Assert.AreEqual(1, retrievedFloors.Count());
                Assert.IsFalse(retrievedFloors.Any(x => x.Id == 1));
            }
        }
    }
}
