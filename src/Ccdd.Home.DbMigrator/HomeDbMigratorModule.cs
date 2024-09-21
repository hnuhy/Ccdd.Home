using Ccdd.Home.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Ccdd.Home.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HomeEntityFrameworkCoreModule),
    typeof(HomeApplicationContractsModule)
)]
public class HomeDbMigratorModule : AbpModule
{
}
