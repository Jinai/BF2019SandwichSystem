﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SandwichSystem.BusinessLayer.UseCases.Assistante;
using SandwichSystem.Shared.Interfaces;
using SandwichSystem.Shared.TransfertObjects;
using System;

namespace SandwichSystem.BusinessLayerTests.UseCases.AssistanteTests
{
    [TestClass]
    public class Supplier_SetDefaultSupplierTests
    {
        [TestMethod]
        public void SetDefaultSupplier_ThrowException_WhenSupplierIDisDifferentOfZero()
        {
            //ARRANGE
            var AssistanteRole = new Assistante((new Mock<IUnitOfWork>()).Object);
            var SupplierToUpdate = new SupplierTO { Id = 0, Name = "InexistantSupplier" };

            //ACT
            Assert.ThrowsException<Exception>(() => AssistanteRole.SetDefaultSupplier(SupplierToUpdate));
        }

        [TestMethod]
        public void SetDefaultSupplier_ThrowException_WhenSupplierIsNull()
        {
            //ARRANGE
            var AssistanteRole = new Assistante((new Mock<IUnitOfWork>()).Object);

            //ACT
            Assert.ThrowsException<ArgumentNullException>(() => AssistanteRole.SetDefaultSupplier(null));
        }

        [TestMethod]
        public void SetDefaultSupplier_ReturnsTrue_WhenAValidSupplierWithIsDefaultTrueIsProvidedAndUpdatedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var AssistanteRole = new Assistante(mockUoW.Object);
            var SupplierToUpdate = new SupplierTO { Id = 10, Name = "ExistantSupplier", IsDefault = true };

            //ACT
            var ReturnValueToAssert = AssistanteRole.SetDefaultSupplier(SupplierToUpdate);

            Assert.IsTrue(ReturnValueToAssert);
        }

        [TestMethod]
        public void SetDefaultSupplier_ReturnsFalse_WhenAValidSupplierWithIsDefaultFalseIsProvidedAndUpdatedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var AssistanteRole = new Assistante(mockUoW.Object);
            var SupplierToUpdate = new SupplierTO { Id = 10, Name = "ExistantSupplier", IsDefault = false };

            //ACT
            Assert.ThrowsException<Exception>(() => AssistanteRole.SetDefaultSupplier(SupplierToUpdate));
        }

        [TestMethod]
        public void UpdateSupplier_SupplierRepositoryIsCalledOnce_WhenAValidSupplierWithIsDefaultTrueIsProvidedAndUpdatedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var AssistanteRole = new Assistante(mockUoW.Object);
            var SupplierToUpdate = new SupplierTO { Id = 10, Name = "ExistantSupplier", IsDefault = true };

            //ACT
            AssistanteRole.SetDefaultSupplier(SupplierToUpdate);

            mockSupplierRepository.Verify(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()), Times.Once);
        }
        [TestMethod]
        public void SetDefaultSupplier_SupplierRepositoryIsCalledNone_WhenAValidSupplierWithIsDefaultFalseIsProvidedAndUpdatedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var AssistanteRole = new Assistante(mockUoW.Object);
            var SupplierToUpdate = new SupplierTO { Id = 10, Name = "ExistantSupplier", IsDefault = false };

            //ACT
            //Assert.ThrowsException<Exception>(()=>
            try { AssistanteRole.SetDefaultSupplier(SupplierToUpdate); } catch { }

            mockSupplierRepository.Verify(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()), Times.Never);
        }

        [TestMethod]
        public void SetDefaultSupplier_ThrowsException_WhenAInvalidSupplierWithIsDefaultTrueIsProvidedAndUpdatedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var AssistanteRole = new Assistante(mockUoW.Object);
            var SupplierToUpdate = new SupplierTO { Id = 10, Name = "", IsDefault = true };

            //ACT
            //Assert.ThrowsException<Exception>(()=>
            try { AssistanteRole.SetDefaultSupplier(SupplierToUpdate); } catch { }

            mockSupplierRepository.Verify(x => x.SetDefaultSupplier(It.IsAny<SupplierTO>()), Times.Never);
        }
    }
}