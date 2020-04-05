using Abp.Module.Ordering.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Module.Ordering
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrderingEntityFrameworkCoreTestModule)
        )]
    public class OrderingDomainTestModule : AbpModule
    {
        
    }
}
