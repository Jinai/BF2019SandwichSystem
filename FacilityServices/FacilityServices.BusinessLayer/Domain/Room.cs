using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Floor Floor { get; set; }

        public Room(string name)
        {
            this.Name = name;
        }
        public Room(string name, Floor floorAttached)
        {
            this.Name = name;
            this.Floor = floorAttached;
        }
    }
}
