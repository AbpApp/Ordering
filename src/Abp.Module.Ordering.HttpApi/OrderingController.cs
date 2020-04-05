using Abp.Module.Ordering.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Module.Ordering
{
    public abstract class OrderingController : AbpController
    {
        protected OrderingController()
        {
            LocalizationResource = typeof(OrderingResource);
        }
    }
}
