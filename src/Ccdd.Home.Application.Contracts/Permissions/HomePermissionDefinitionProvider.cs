using Ccdd.Home.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Ccdd.Home.Permissions;

public class HomePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HomePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(HomePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HomeResource>(name);
    }
}
