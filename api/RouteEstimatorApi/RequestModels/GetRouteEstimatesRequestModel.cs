

namespace RouteEstimatorApi.RequestModels
{
    using System;
    public class GetRouteEstimatesRequestModel
    {
        public DateTime CurrentTime { get; set; }
        public int StopNumber { get; set; }
        public int RouteNumber { get; set; }
    }
}
