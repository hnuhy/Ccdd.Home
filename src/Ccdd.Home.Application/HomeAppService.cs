using Ccdd.Home.Localization;
using Volo.Abp.Application.Services;

namespace Ccdd.Home;

/* Inherit your application services from this class.
 */
public abstract class HomeAppService : ApplicationService
{
    protected HomeAppService()
    {
        LocalizationResource = typeof(HomeResource);
    }
}
