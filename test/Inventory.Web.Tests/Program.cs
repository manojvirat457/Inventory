using Microsoft.AspNetCore.Builder;
using Inventory;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<InventoryWebTestModule>();

public partial class Program
{
}
