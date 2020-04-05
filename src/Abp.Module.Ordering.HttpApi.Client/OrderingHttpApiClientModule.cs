using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Abp.Module.Ordering
{
    [DependsOn(
        typeof(OrderingApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OrderingHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Ordering";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderingApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
