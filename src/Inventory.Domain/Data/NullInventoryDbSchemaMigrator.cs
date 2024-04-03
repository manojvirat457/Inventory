using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Inventory.Data;

/* This is used if database provider does't define
 * IInventoryDbSchemaMigrator implementation.
 */
public class NullInventoryDbSchemaMigrator : IInventoryDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
