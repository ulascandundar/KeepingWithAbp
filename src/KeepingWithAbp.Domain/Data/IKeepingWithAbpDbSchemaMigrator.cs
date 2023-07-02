using System.Threading.Tasks;

namespace KeepingWithAbp.Data;

public interface IKeepingWithAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
