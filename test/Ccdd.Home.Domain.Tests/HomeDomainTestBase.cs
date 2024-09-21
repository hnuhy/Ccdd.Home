using Volo.Abp.Modularity;

namespace Ccdd.Home;

/* Inherit from this class for your domain layer tests. */
public abstract class HomeDomainTestBase<TStartupModule> : HomeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
