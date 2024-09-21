using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Ccdd.Home.Pages;

[Collection(HomeTestConsts.CollectionDefinitionName)]
public class Index_Tests : HomeWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
