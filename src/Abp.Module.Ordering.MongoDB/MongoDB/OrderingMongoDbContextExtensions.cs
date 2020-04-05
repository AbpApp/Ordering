using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.Module.Ordering.MongoDB
{
    public static class OrderingMongoDbContextExtensions
    {
        public static void ConfigureOrdering(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrderingMongoModelBuilderConfigurationOptions(
                OrderingDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}