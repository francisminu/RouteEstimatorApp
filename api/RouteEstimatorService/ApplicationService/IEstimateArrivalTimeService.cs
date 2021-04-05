

namespace RouteEstimatorService.ApplicationService
{
    using System;
    using System.Threading.Tasks;

    public interface IEstimateArrivalTimeService
    {
        Task<Response> GetRouteEstimates(DateTime currentTime, int stopNumber);
    }
}
