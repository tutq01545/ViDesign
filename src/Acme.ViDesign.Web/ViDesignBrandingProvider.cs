using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.ViDesign.Web
{
    [Dependency(ReplaceServices = true)]
    public class ViDesignBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ViDesign";
    }
}
