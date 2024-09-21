using Volo.Abp.Modularity;

namespace Ccdd.Home;

[DependsOn(
    typeof(HomeDomainModule),
    typeof(HomeTestBaseModule)
)]
public class HomeDomainTestModule : AbpModule
{

}
