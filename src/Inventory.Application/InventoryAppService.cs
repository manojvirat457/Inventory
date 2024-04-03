using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Localization;
using Volo.Abp.Application.Services;

namespace Inventory;

/* Inherit your application services from this class.
 */
public abstract class InventoryAppService : ApplicationService
{
    protected InventoryAppService()
    {
        LocalizationResource = typeof(InventoryResource);
    }
}
