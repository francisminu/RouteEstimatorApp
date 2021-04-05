using System;
using System.Collections.Generic;
using System.Text;

namespace RouteEstimatorService.ResponseModels
{
    public class RouteModel
    {
        public string RouteName { get; set; }
        public int NextArrivalTime { get; set; }
        public int SecondArrivalTime { get; set; }
    }
}
