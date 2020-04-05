using Abp.Module.Ordering.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Module.Ordering
{
    public abstract class OrderingAppService : ApplicationService
    {
        protected OrderingAppService()
        {
            LocalizationResource = typeof(OrderingResource);
            ObjectMapperContext = typeof(OrderingApplicationModule);
        }
    }
}
