using KeepingWithAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace KeepingWithAbp.Permissions;

public class KeepingWithAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(KeepingWithAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(KeepingWithAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<KeepingWithAbpResource>(name);
    }
}
