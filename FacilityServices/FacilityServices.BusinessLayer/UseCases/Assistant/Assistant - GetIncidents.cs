using FacilityServices.BusinessLayer.Extensions;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AssistantRole
    {
        public List<IncidentTO> GetIncidents()
        {


            return iFSUnitOfWork.IncidentRepository
                .GetAll()
                .Select(x => x.ToDomain().ToTransfertObject())
                .ToList();
        }
    }
}
