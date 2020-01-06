using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Floor FloorAttached { get; set; }
    }
}
