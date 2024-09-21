using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Ccdd.Home.Localization;

namespace Ccdd.Home.Web;

[Dependency(ReplaceServices = true)]
public class HomeBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HomeResource> _localizer;

    public HomeBrandingProvider(IStringLocalizer<HomeResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
