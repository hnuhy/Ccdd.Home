using Volo.Abp.Modularity;

namespace Ccdd.Home;

[DependsOn(
    typeof(HomeApplicationModule),
    typeof(HomeDomainTestModule)
)]
public class HomeApplicationTestModule : AbpModule
{

}
