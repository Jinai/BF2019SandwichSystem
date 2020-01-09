using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.Exceptions;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FacilityServices.DataLayerTests.RepositoriesTests.ComponentTypeRepositoryTests
{
    [TestClass]
    public class GetComponentTypesTests
    {
        [TestMethod]
        public void GetComponentTypeById_ThrowsException_WhenInvalidIdIsProvided()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                var componentTypeRepository = new ComponentTypeRepository(memoryCtx);

                Assert.ThrowsException<NotExistingComponentTypeException>(() => componentTypeRepository.GetByID(100));
            }
        }
        [TestMethod]
        public void GetComponentTypeById_Successfull()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                var ComponentTypeToUseInTest = new ComponentTypeTO
                {
                    Archived = false,
                    Name = new MultiLanguageString("Name1En", "Name1Fr", "Name1Nl"),
                };
                var ComponentTypeToUseInTest2 = new ComponentTypeTO
                {
                    Archived = false,
                    Name = new MultiLanguageString("Name2En", "Name2Fr", "Name2Nl"),
                };

                var componentTypeRepository = new ComponentTypeRepository(memoryCtx);

                componentTypeRepository.Add(ComponentTypeToUseInTest);
                memoryCtx.SaveChanges();

                //var ComponentTypeToAssert = componentTypeRepository.GetByID(2);
                //Assert.AreEqual(2, ComponentTypeToAssert.Id);
                //Assert.AreEqual(0, ComponentTypeToAssert.Number);
            }
        }

        [TestMethod]
        public void GetAllComponentTypes_Successfull()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                var ComponentTypeToUseInTest = new ComponentTypeTO
                {
                    
                };

                var ComponentTypeToUseInTest1 = new ComponentTypeTO
                {
                   
                };
                var ComponentTypeToUseInTest2 = new ComponentTypeTO
                {
                   
                };
                var componentTypeRepository = new ComponentTypeRepository(memoryCtx);

                componentTypeRepository.Add(ComponentTypeToUseInTest);
                componentTypeRepository.Add(ComponentTypeToUseInTest1);
                componentTypeRepository.Add(ComponentTypeToUseInTest2);
                memoryCtx.SaveChanges();

                //Assert.AreEqual(3, componentTypeRepository.GetAll().Count());
            }
        }
    }
}
