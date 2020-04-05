using Abp.Module.Ordering.Samples;

namespace Abp.Module.Ordering.EntityFrameworkCore.Samples
{
    public class SampleRepository_Tests : SampleRepository_Tests<OrderingEntityFrameworkCoreTestModule>
    {
        /* Don't write custom repository tests here, instead write to
         * the base class.
         * One exception can be some specific tests related to EF core.
         */
    }
}
