﻿using FacilityServices.BusinessLayer.UseCases;
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
    public class Attendee_GetComponentTypesByRoomTests
    {
        [TestMethod]
        public void GetComponentTypesByRoom_ReturnRooms()
        {
            ////Floor
            //var floor1 = new FloorTO { Number = 2 };
            //var floor2 = new FloorTO { Number = -1 };
            ////Room
            //var rooms = new List<RoomTO>
            //{
            //    new RoomTO {Id = 1, Archived = false, Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = floor1 },
            //    new RoomTO {Id = 2, Archived = false, Name = new MultiLanguageString("Room2", "Room2", "Room2"), Floor = floor1 },
            //    new RoomTO {Id = 3, Archived = false, Name = new MultiLanguageString("Room3", "Room3", "Room3"), Floor = floor2 }
            //};
            //var componentTypes = new List<ComponentTypeTO>
            //{
            //    new ComponentTypeTO {Id = 1, Archived = false, Name = new MultiLanguageString("Name1", "Name1", "Name1") },
            //    new ComponentTypeTO {Id = 2, Archived = false, Name = new MultiLanguageString("Name2", "Name2", "Name2") },
            //    new ComponentTypeTO {Id = 3, Archived = false, Name = new MultiLanguageString("Name3", "Name3", "Name3") },
              
            //};
            ////ARRANGE
            //var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            //mockUnitOfWork.Setup(u => u.ComponentTypeRepository.GetComponentTypesByRoom(It.IsAny<RoomTO>()))
            //              .Returns(componentTypes);
            //var sut = new AssistantRole(mockUnitOfWork.Object);
            //var room = new ComponentTypeTO { Id = 1, Archived = false, Name = new MultiLanguageString("Name1", "Name1", "Name1") };
            ////ACT
            //var result = sut.GetComponentTypesByRoom({ Id = 1, Archived = false, Name = new MultiLanguageString("Room1", "Room1", "Room1"), Floor = floor1 });
            ////ASSERT
            //mockUnitOfWork.Verify(u => u.RoomRepository.GetComponentTypesByRoom(It.IsAny<FloorTO>()), Times.Once);
            //Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetComponentTypesByRoom_NullFloorSubmitted_ThrowArgumentNullException()
        {
            //ARRANGE
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            var sut = new AssistantRole(mockUnitOfWork.Object);
            //ACT

            //ASSERT
            Assert.ThrowsException<ArgumentNullException>(() => sut.GetComponentTypesByRoom(null));
        }

        [TestMethod]
        public void GetComponentTypesByRoom_IncorrectRoomID_ThrowLoggedException()
        {
            //ARRANGE
            var mockUnitOfWork = new Mock<IFSUnitOfWork>();
            var sut = new AssistantRole(mockUnitOfWork.Object);
            //ACT

            //ASSERT
            Assert.ThrowsException<LoggedException>(() => sut.GetComponentTypesByRoom(new RoomTO { Archived = false }));
        }
    }
}