using Inventory.Samples;
using Xunit;

namespace Inventory.EntityFrameworkCore.Applications;

[Collection(InventoryTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<InventoryEntityFrameworkCoreTestModule>
{

}
