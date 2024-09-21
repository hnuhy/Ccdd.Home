using Ccdd.Home.Samples;
using Xunit;

namespace Ccdd.Home.EntityFrameworkCore.Domains;

[Collection(HomeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HomeEntityFrameworkCoreTestModule>
{

}
