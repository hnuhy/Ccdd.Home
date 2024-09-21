using Ccdd.Home.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ccdd.Home.Web.Pages;

public abstract class HomePageModel : AbpPageModel
{
    protected HomePageModel()
    {
        LocalizationResourceType = typeof(HomeResource);
    }
}
