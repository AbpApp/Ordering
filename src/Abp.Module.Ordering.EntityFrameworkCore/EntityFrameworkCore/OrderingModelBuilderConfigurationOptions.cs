using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Module.Ordering.EntityFrameworkCore
{
    public class OrderingModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OrderingModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}