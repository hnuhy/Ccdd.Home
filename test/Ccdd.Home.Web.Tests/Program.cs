using Microsoft.AspNetCore.Builder;
using Ccdd.Home;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<HomeWebTestModule>();

public partial class Program
{
}
