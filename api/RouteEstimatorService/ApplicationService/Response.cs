using RouteEstimatorService.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RouteEstimatorService.ApplicationService
{
    public class Response
    {
        public IEnumerable<RouteModel> RoutesList { get; set; }
    }
}
