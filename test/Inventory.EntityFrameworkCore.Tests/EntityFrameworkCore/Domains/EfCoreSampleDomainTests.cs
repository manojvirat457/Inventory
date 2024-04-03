using Inventory.Samples;
using Xunit;

namespace Inventory.EntityFrameworkCore.Domains;

[Collection(InventoryTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<InventoryEntityFrameworkCoreTestModule>
{

}
