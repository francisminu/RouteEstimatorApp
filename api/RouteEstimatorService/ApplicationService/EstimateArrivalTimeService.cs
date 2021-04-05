﻿



namespace RouteEstimatorService.ApplicationService
{
    using RouteEstimatorService.ResponseModels;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    public class EstimateArrivalTimeService: IEstimateArrivalTimeService
    {
        private const int visitTimePerSameRoute = 15;
        private const int visitTimePerStopPerRoute = 2;
        private const int numberOfRoutes = 3;
        public async Task<Response> GetRouteEstimates(DateTime currentTime, int stopNumber)
        {
            return await Task.Run(async () =>
            {
                var minutesValue = currentTime.Minute;
                var timeElapsedByRoute1AtStop1 = minutesValue % visitTimePerSameRoute;
                var routesData = new List<RouteModel>();
                for(int i = 0; i< numberOfRoutes; i++)
                {
                    var routeData = await GetRouteDataByRouteNumber(timeElapsedByRoute1AtStop1, currentTime, stopNumber, i);
                    routesData.Add(routeData);
                }

                return new Response
                {
                    RoutesList = routesData
                };
            }, CancellationToken.None);
            
        }

        private async Task<RouteModel> GetRouteDataByRouteNumber(int timeElapsedByRoute1AtStop1, DateTime currentTime, int stopNumber, int routeNumberIndex)
        {
            return await Task.Run(() =>
            {
                                
                var nextArrivalTime = visitTimePerSameRoute - (timeElapsedByRoute1AtStop1 - (visitTimePerStopPerRoute * (stopNumber - 1))) + (visitTimePerStopPerRoute * routeNumberIndex);
                if(nextArrivalTime > visitTimePerSameRoute)
                {
                    nextArrivalTime -= visitTimePerSameRoute;
                }
                return new RouteModel
                {
                    RouteName = $"Route {routeNumberIndex + 1}",
                    NextArrivalTime = nextArrivalTime,
                    SecondArrivalTime = nextArrivalTime + visitTimePerSameRoute
                };
            }, CancellationToken.None);
            
        }
    }
}
