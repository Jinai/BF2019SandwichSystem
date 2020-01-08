﻿using OnlineServices.Shared.FacilityServices.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.BusinessLayer.Domain
{
    public class Incident
    {
        public int Id { get; set; }
        public Component Component { get; set; }
        public Issue Issue { get; set; }
        public List<Comment> AssistantComments { get; set; } = new List<Comment>();
        public string Description { get; set; }
        public DateTime SubmitDate { get; set; }
        public IncidentStatus Status { get; set; }
    }
}
