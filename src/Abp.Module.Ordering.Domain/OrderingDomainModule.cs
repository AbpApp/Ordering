using Volo.Abp.Modularity;

namespace Abp.Module.Ordering
{
    [DependsOn(
        typeof(OrderingDomainSharedModule)
        )]
    public class OrderingDomainModule : AbpModule
    {

    }
}
