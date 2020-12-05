using Acme.ViDesign.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.ViDesign.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ViDesignController : AbpController
    {
        protected ViDesignController()
        {
            LocalizationResource = typeof(ViDesignResource);
        }
    }
}