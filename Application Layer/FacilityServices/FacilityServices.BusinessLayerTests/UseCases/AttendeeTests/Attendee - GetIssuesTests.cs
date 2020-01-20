using FacilityServices.BusinessLayer.UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.Interfaces;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using OnlineServices.Common.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayerTests.UseCases.AttendeeTests
{
    [TestClass]
    public class Attendee_GetIssuesByComponentTypeTests
    {
        [TestMethod]
        public void GetIssuesByComponentType_ReturnIssues()
        {
            var componentType1 = new ComponentTypeTO {Id = 1, Archived = false, Name = new MultiLanguageString("Name1En", "Name1Fr", "Name1Nl") };
            var componentType2 = new ComponentTypeTO {Id = 2, Archived = false, Name = new MultiLanguageString("Name2En", "Name2Fr", "Name2Nl") };
            //Issue
            var issues = new List<IssueTO>
            {
             new IssueTO {Id = 1, Archived = false, Description = "Plus de café", Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL"), ComponentType = componentType1 },
             new IssueTO {Id = 2, Archived = false, Description = "Fuite d'eau", Name = new MultiLanguageString("Issue2EN", "Issue2FR", "Issue2NL"), ComponentType = componentType2 },
             new IssueTO {Id = 3, Archived = false, Description = "Plus de PQ", Name = new MultiLanguageString("Issue3EN", "Issue3FR", "Issue3NL"), ComponentType = componentType2 },
            };
            //ARRANGE
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            //mockUnitOfWork.Setup(u => u.IssueRepository.GetIssuesByComponentType(It.IsAny<ComponentTypeTO>)
            //              .Returns(issues);
            var sut = new AssistantRole(mockUnitOfWork.Object);
            var room = new IssueTO { Id = 1, Archived = false, Description = "Plus de café", Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL"), ComponentType = componentType1 };
            //ACT
            var result = sut.GetIssuesByComponentType(1);
            //ASSERT
            mockUnitOfWork.Verify(u => u.IssueRepository.GetIssuesByComponentType(It.IsAny<ComponentTypeTO>()), Times.Once);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetIssuesByComponentType_IncorrectRoomID_ThrowLoggedException()
        {
            //ARRANGE
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            var sut = new AssistantRole(mockUnitOfWork.Object);
            Assert.ThrowsException<LoggedException>(() => sut.GetIssuesByComponentType(-1));
        }
    }
}