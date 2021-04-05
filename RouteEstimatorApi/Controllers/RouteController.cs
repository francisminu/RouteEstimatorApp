#region fileHeader

// <application>RouteEstimatorApplication</application> 
// <module>InventoryControl.Api</module>
// <author>Francis, Minu</author> 
// <createddate>2020-01-15</createddate>
// <lastchangedby>Varghese, Biju</lastchangedby>
// <lastchangeddate>2020-07-13</lastchangeddate>

#endregion

namespace RouteEstimatorApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using RouteEstimatorApi.RequestModels;
    using RouteEstimatorApi.ResponseModels;
    using RouteEstimatorService.ApplicationService;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api")]
    public class RouteController : ControllerBase
    {
        
        private readonly IEstimateArrivalTimeService _estimateArrivalTimeService;


        private readonly ILogger<RouteController> _logger;

        public RouteController(ILogger<RouteController> logger, IEstimateArrivalTimeService estimateArrivalTimeService)
        {
            _logger = logger;
            _estimateArrivalTimeService = estimateArrivalTimeService;
        }

        [HttpPut]
        //[Route("estimations/get")]
        public async Task<Response> GetRouteEstimates(GetRouteEstimatesRequestModel requestModel)
        {
            _logger.LogInformation("Test log!"); // please check the debug console to see the logs being written
            var result = await _estimateArrivalTimeService.GetRouteEstimates(requestModel.CurrentTime, requestModel.StopNumber);
            return result;
        }
    }
}
