using Acme.ViDesign.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.ViDesign.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ViDesignPageModel : AbpPageModel
    {
        protected ViDesignPageModel()
        {
            LocalizationResourceType = typeof(ViDesignResource);
        }
    }
}