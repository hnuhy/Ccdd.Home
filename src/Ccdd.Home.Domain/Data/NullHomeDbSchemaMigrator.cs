using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Ccdd.Home.Data;

/* This is used if database provider does't define
 * IHomeDbSchemaMigrator implementation.
 */
public class NullHomeDbSchemaMigrator : IHomeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
