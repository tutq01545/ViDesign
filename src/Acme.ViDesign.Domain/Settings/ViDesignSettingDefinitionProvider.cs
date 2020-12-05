using Volo.Abp.Settings;

namespace Acme.ViDesign.Settings
{
    public class ViDesignSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ViDesignSettings.MySetting1));
        }
    }
}
