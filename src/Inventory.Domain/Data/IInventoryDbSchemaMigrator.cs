using System.Threading.Tasks;

namespace Inventory.Data;

public interface IInventoryDbSchemaMigrator
{
    Task MigrateAsync();
}
