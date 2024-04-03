using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Inventory.Pages;

public class Index_Tests : InventoryWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
