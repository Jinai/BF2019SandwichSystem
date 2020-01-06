using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.Interfaces.Repositories
{
    public interface IIssueRepository : IRepositoryTemp<IssueTO, int>
    {
        // Comme pour Floor, as-t'on besoin de cette interface ? Nous n'avons pas de signature supplémentaire à y intégrer...
    }
}
