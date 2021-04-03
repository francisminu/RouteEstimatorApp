

namespace RouteEstimatorService.DependencyResolver
{
    using Autofac;
    using RouteEstimatorService.ApplicationService;
    public class ApplicationServiceDependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EstimateArrivalTimeService>().As<IEstimateArrivalTimeService>();
        }
    }
}
