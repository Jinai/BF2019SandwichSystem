using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class ReportRepository : IReportRepository
    {
        private FacilityContext facilityContext;

        public ReportRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}