


namespace RouteEstimatorApi.DependancyResolver
{
    using Autofac;
    using RouteEstimatorService.DependencyResolver;
    public class ApiDependencyResolver: Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region Module Registration

            builder.RegisterModule(new ApplicationServiceDependencyResolver());
            
            #endregion
        }
    }
    
}
