
using Microsoft.AspNetCore.Http;

namespace RouteEstimatorApi.ResponseModels
{
    public class GetRouteEstimatesResponseModel
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
    }
}
