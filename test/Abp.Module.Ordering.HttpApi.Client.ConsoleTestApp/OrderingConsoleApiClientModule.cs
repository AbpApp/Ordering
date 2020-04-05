using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.Module.Ordering
{
    [DependsOn(
        typeof(OrderingHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrderingConsoleApiClientModule : AbpModule
    {
        
    }
}
