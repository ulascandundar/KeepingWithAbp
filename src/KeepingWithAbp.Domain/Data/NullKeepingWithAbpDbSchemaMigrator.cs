using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace KeepingWithAbp.Data;

/* This is used if database provider does't define
 * IKeepingWithAbpDbSchemaMigrator implementation.
 */
public class NullKeepingWithAbpDbSchemaMigrator : IKeepingWithAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
