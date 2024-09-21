using Volo.Abp.Modularity;

namespace Ccdd.Home;

public abstract class HomeApplicationTestBase<TStartupModule> : HomeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
