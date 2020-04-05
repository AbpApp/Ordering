using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.Module.Ordering.MongoDB
{
    public class OrderingMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OrderingMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}