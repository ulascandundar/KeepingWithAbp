using Volo.Abp.Settings;

namespace KeepingWithAbp.Settings;

public class KeepingWithAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(KeepingWithAbpSettings.MySetting1));
    }
}
