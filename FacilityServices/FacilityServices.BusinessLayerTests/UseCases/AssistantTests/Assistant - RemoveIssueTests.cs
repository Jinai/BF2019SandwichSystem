﻿using FacilityServices.BusinessLayer.UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.Interfaces;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using OnlineServices.Common.TranslationServices.TransfertObjects;
using System.Collections.Generic;

namespace FacilityServices.BusinessLayerTests.UseCases.AssistantTests
{
    [TestClass]
    public class Assistant_RemoveIssue
    {
        [TestMethod]
        public void RemoveIssue_ReturnTrue()
        {
            //Component
            var componentType1 = new ComponentTypeTO { Archived = false, Name = new MultiLanguageString("Name1En", "Name1Fr", "Name1Nl") };
            var componentType2 = new ComponentTypeTO { Archived = false, Name = new MultiLanguageString("Name2En", "Name2Fr", "Name2Nl") };
            //Issue
            var issue1 = new IssueTO { Description = "Plus de café", Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL"), ComponentType = componentType1 };
            var issue2 = new IssueTO { Description = "Fuite d'eau", Name = new MultiLanguageString("Issue2EN", "Issue2FR", "Issue2NL"), ComponentType = componentType2 };
            var issue3 = new IssueTO { Description = "Plus de PQ", Name = new MultiLanguageString("Issue3EN", "Issue3FR", "Issue3NL"), ComponentType = componentType2 };

            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            mockUnitOfWork.Setup(u => u.IssueRepository.GetById(It.IsAny<int>()))
                          .Returns(new IssueTO {Id=1, Archived = false, Description = "Plus de café", Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL"), ComponentType = componentType1 });
            mockUnitOfWork.Setup(u => u.IssueRepository.Update(It.IsAny<IssueTO>()))
                          .Returns(new IssueTO {Id=1, Archived = true, Description = "Plus de café", Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL"), ComponentType = componentType1 });
            
            var sut = new AssistantRole(mockUnitOfWork.Object);
            var result = sut.RemoveIssue(1);
            mockUnitOfWork.Verify(u => u.IssueRepository.Update(It.IsAny<IssueTO>()), Times.Once);
            mockUnitOfWork.Verify(u => u.IssueRepository.GetById(It.IsAny<int>()), Times.Once);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemoveIssue_IncorrectIssueID_ThrowLoggedException()
        {
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            var sut = new AssistantRole(mockUnitOfWork.Object);
            Assert.ThrowsException<LoggedException>(() => sut.RemoveIssue(0));
        }

        [TestMethod]
        public void Removeissue_IssueDoesntExist_ThrowKeyNotFoundException()
        {
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            mockUnitOfWork.Setup(u => u.IssueRepository.GetById(It.IsAny<int>())).Returns(() => null);
            var sut = new AssistantRole(mockUnitOfWork.Object);
            
            Assert.ThrowsException<KeyNotFoundException>(() => sut.RemoveIssue(1));
        }
    }
}