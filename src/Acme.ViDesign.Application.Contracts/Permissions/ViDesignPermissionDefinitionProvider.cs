using Acme.ViDesign.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.ViDesign.Permissions
{
    public class ViDesignPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ViDesignPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ViDesignPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ViDesignResource>(name);
        }
    }
}
