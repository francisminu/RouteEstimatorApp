

namespace RouteEstimatorService.Test.ApplicationService
{
    using RouteEstimatorService.ApplicationService;
    using System;
    using System.Threading.Tasks;
    using Xunit;
    using Moq;
    using System.Linq;

    public class EstimateArrivalTimeServiceTests
    {
        #region EdgeCase 1
        
        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number1_EdgeCase1()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 45, 00);
            var stopNumber = 1;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 15;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number2_EdgeCase1()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 45, 00);
            var stopNumber = 2;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 2;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number3_EdgeCase1()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 45, 00);
            var stopNumber = 3;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 4;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        #endregion

        #region EdgeCase 2

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number1_EdgeCase2()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 01, 00);
            var stopNumber = 1;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 14;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number2_EdgeCase2()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 01, 00);
            var stopNumber = 2;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 1;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number3_EdgeCase2()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 01, 00);
            var stopNumber = 3;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 3;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        #endregion

        #region EdegeCase 3

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number1_EdgeCase3()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 02, 00);
            var stopNumber = 1;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 13;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number2_EdgeCase3()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 02, 00);
            var stopNumber = 2;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 15;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        [Fact]
        public async Task Can_Get_Route_Schedules_For_Stop_Number3_EdgeCase3()
        {
            var currentTime = new DateTime(2021, 04, 05, 01, 02, 00);
            var stopNumber = 3;
            var estimatorService = new EstimateArrivalTimeService();

            var response = await estimatorService.GetRouteEstimates(currentTime, stopNumber);
            var routesList = response.RoutesList.ToList();
            var expectedNextArrivalTimeForRoute1 = 2;
            Assert.Equal(expectedNextArrivalTimeForRoute1, routesList[0].NextArrivalTime);
        }

        #endregion
    }
}
