using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouteEstimatorApi.RequestModels;
using RouteEstimatorApi.ResponseModels;
using RouteEstimatorService.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteEstimatorApi.Controllers
{
    [ApiController]
    [Route("api/route")]
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
        [Route("estimations/get")]
        public async Task<GetRouteEstimatesResponseModel> GetRouteEstimates(GetRouteEstimatesRequestModel requestModel)
        {
            await _estimateArrivalTimeService.GetRouteEstimates(requestModel.CurrentTime, requestModel.StopNumber, requestModel.RouteNumber);
            return new GetRouteEstimatesResponseModel();
        }
    }
}
