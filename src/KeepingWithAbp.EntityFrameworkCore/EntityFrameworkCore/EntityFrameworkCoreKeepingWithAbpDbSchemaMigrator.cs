using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KeepingWithAbp.Data;
using Volo.Abp.DependencyInjection;

namespace KeepingWithAbp.EntityFrameworkCore;

public class EntityFrameworkCoreKeepingWithAbpDbSchemaMigrator
    : IKeepingWithAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreKeepingWithAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the KeepingWithAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<KeepingWithAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
