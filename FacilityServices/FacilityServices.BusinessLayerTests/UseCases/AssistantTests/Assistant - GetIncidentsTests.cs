using FacilityServices.BusinessLayer.UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Common.FacilityServices.Interfaces;
using OnlineServices.Common.FacilityServices.Interfaces.Repositories;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacilityServices.BusinessLayerTests.UseCases.AssistantTests
{
    [TestClass]
    public class Assistant_GetIncidentsTests
    {
        public static List<IncidentTO> IncidentList()
        {
            return new List<IncidentTO>
            {
                new IncidentTO { },
                new IncidentTO { },
                new IncidentTO { }
            };
        }

        [TestMethod]
        public void GetSuppliers_ReturnsSupplierInDB_WhenCalled()
        {
            var mockIncidentRepository = new Mock<IIncidentRepository>();
            mockIncidentRepository.Setup(x => x.GetAll()).Returns(IncidentList());

            var mockUoW = new Mock<IFSUnitOfWork>();
            mockUoW.Setup(x => x.IncidentRepository).Returns(mockIncidentRepository.Object);

            var Assistante = new AssistantRole(mockUoW.Object);

            var suppliers = Assistante.GetIncidents();

           // Assert.AreEqual(IncidentList().Count(), incidents.Count());
        }

        //[TestMethod]
        //public void GetSuppliers_SupplierRepositoryIsCalledOnce_WhenCalled()
        //{
        //    //ARRANGE
        //    var mockSupplierRepository = new Mock<ISupplierRepository>();
        //    mockSupplierRepository.Setup(x => x.GetAll()).Returns(SupplierList());

        //    var mockUoW = new Mock<IMSUnitOfWork>();
        //    mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

        //    var Assistante = new AssistantRole(mockUoW.Object);

        //    //ACT
        //    Assistante.GetSuppliers();

        //    //ASSERT
        //    mockSupplierRepository.Verify(x => x.GetAll(), Times.Once);
        //}
        
    }
}
