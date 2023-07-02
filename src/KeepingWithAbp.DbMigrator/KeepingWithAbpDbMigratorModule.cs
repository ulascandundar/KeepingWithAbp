using KeepingWithAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace KeepingWithAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(KeepingWithAbpEntityFrameworkCoreModule),
    typeof(KeepingWithAbpApplicationContractsModule)
    )]
public class KeepingWithAbpDbMigratorModule : AbpModule
{

}
