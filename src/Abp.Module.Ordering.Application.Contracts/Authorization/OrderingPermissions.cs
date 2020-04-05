using Volo.Abp.Reflection;

namespace Abp.Module.Ordering.Authorization
{
    public class OrderingPermissions
    {
        public const string GroupName = "Ordering";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrderingPermissions));
        }
    }
}