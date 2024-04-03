using Volo.Abp.Modularity;

namespace Inventory;

[DependsOn(
    typeof(InventoryApplicationModule),
    typeof(InventoryDomainTestModule)
)]
public class InventoryApplicationTestModule : AbpModule
{

}
