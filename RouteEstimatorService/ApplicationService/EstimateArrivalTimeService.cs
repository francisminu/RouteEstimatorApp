



namespace RouteEstimatorService.ApplicationService
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public class EstimateArrivalTimeService: IEstimateArrivalTimeService
    {
        private const int visitTimePerSameRoute = 15;
        private const int visitTimePerStopPerRoute = 2;
        public async Task GetRouteEstimates(DateTime currentTime, int stopNumber, int routeNumber)
        {
            await Task.Run(() =>
            {
                var minutesValue = currentTime.Minute;
                var timeElapsedByRoute1AtStop1 = minutesValue % visitTimePerSameRoute;
                // time that it will arrive at Stop2, Route 1

                var test = Math.Abs(timeElapsedByRoute1AtStop1 - visitTimePerStopPerRoute * (stopNumber - 1)) + visitTimePerStopPerRoute * (routeNumber - 1);
            }, CancellationToken.None);
            
        }
    }
}
