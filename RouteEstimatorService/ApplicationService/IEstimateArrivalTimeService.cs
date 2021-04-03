

namespace RouteEstimatorService.ApplicationService
{
    using System;
    using System.Threading.Tasks;

    public interface IEstimateArrivalTimeService
    {
        Task GetRouteEstimates(DateTime currentTime, int stopNumber, int routeNumber);
    }
}
