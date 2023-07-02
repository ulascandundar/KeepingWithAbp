using KeepingWithAbp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace KeepingWithAbp.Blazor;

public abstract class KeepingWithAbpComponentBase : AbpComponentBase
{
    protected KeepingWithAbpComponentBase()
    {
        LocalizationResource = typeof(KeepingWithAbpResource);
    }
}
