using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace KeepingWithAbp.Blazor;

[Dependency(ReplaceServices = true)]
public class KeepingWithAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "KeepingWithAbp";
}
