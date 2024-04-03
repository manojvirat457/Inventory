using Inventory.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Inventory.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class InventoryController : AbpControllerBase
{
    protected InventoryController()
    {
        LocalizationResource = typeof(InventoryResource);
    }
}
