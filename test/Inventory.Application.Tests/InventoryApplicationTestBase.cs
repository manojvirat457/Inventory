using Volo.Abp.Modularity;

namespace Inventory;

public abstract class InventoryApplicationTestBase<TStartupModule> : InventoryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
