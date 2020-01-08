﻿using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public Floor Floor { get; set; }
        public bool Archived { get; set; }
        public List<Component> Components { get; set; } = new List<Component>();

        public Room(MultiLanguageString name)
        {
            this.Name = name;
        }
        public Room(MultiLanguageString name, Floor floorAttached)
        {
            this.Name = name;
            this.Floor = floorAttached;
        }
    }
}
