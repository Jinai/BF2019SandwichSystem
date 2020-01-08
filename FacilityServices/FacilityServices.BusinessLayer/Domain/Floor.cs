using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer.Domain
{
    public class Floor
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool Archived { get; set; }

        public Floor(int number)
        {
            this.Number = number;
        }
    }
}
