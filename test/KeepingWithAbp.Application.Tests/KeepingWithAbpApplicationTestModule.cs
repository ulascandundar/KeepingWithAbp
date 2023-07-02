using Volo.Abp.Modularity;

namespace KeepingWithAbp;

[DependsOn(
    typeof(KeepingWithAbpApplicationModule),
    typeof(KeepingWithAbpDomainTestModule)
    )]
public class KeepingWithAbpApplicationTestModule : AbpModule
{

}
