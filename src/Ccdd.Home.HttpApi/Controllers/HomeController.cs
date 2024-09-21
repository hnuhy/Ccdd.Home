using Ccdd.Home.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Ccdd.Home.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HomeController : AbpControllerBase
{
    protected HomeController()
    {
        LocalizationResource = typeof(HomeResource);
    }
}
