using Xunit;

namespace Ccdd.Home.EntityFrameworkCore;

[CollectionDefinition(HomeTestConsts.CollectionDefinitionName)]
public class HomeEntityFrameworkCoreCollection : ICollectionFixture<HomeEntityFrameworkCoreFixture>
{

}
