using KeepingWithAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace KeepingWithAbp;

[DependsOn(
    typeof(KeepingWithAbpEntityFrameworkCoreTestModule)
    )]
public class KeepingWithAbpDomainTestModule : AbpModule
{

}
