using System.Threading.Tasks;

namespace Ccdd.Home.Data;

public interface IHomeDbSchemaMigrator
{
    Task MigrateAsync();
}
