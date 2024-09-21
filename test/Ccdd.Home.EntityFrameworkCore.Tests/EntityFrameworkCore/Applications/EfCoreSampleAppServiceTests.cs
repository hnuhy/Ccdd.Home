using Ccdd.Home.Samples;
using Xunit;

namespace Ccdd.Home.EntityFrameworkCore.Applications;

[Collection(HomeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HomeEntityFrameworkCoreTestModule>
{

}
