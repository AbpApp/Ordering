using Volo.Abp.Modularity;

namespace Abp.Module.Ordering
{
    [DependsOn(
        typeof(OrderingApplicationModule),
        typeof(OrderingDomainTestModule)
        )]
    public class OrderingApplicationTestModule : AbpModule
    {

    }
}
