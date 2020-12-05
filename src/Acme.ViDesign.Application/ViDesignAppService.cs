using System;
using System.Collections.Generic;
using System.Text;
using Acme.ViDesign.Localization;
using Volo.Abp.Application.Services;

namespace Acme.ViDesign
{
    /* Inherit your application services from this class.
     */
    public abstract class ViDesignAppService : ApplicationService
    {
        protected ViDesignAppService()
        {
            LocalizationResource = typeof(ViDesignResource);
        }
    }
}
