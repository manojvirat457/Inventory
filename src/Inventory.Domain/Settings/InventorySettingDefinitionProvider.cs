using Volo.Abp.Settings;

namespace Inventory.Settings;

public class InventorySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(InventorySettings.MySetting1));
    }
}
