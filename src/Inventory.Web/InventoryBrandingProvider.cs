using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Inventory.Web;

[Dependency(ReplaceServices = true)]
public class InventoryBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Inventory";
}
