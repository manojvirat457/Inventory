using Volo.Abp.Modularity;

namespace Inventory;

/* Inherit from this class for your domain layer tests. */
public abstract class InventoryDomainTestBase<TStartupModule> : InventoryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
