using Abp.Module.Ordering.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Module.Ordering.Authorization
{
    public class OrderingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(OrderingPermissions.GroupName, L("Permission:Ordering"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OrderingResource>(name);
        }
    }
}