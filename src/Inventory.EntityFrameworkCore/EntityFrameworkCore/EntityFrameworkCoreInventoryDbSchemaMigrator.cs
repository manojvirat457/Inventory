using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Inventory.Data;
using Volo.Abp.DependencyInjection;

namespace Inventory.EntityFrameworkCore;

public class EntityFrameworkCoreInventoryDbSchemaMigrator
    : IInventoryDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreInventoryDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the InventoryDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<InventoryDbContext>()
            .Database
            .MigrateAsync();
    }
}
