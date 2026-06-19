using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NerdStore.WebApp.MVC.Data
{
    public static class DatabaseMigrationExtensions
    {
        public static void ApplyPendingMigrations<TContext>(this IApplicationBuilder app)
            where TContext : DbContext
        {
            using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<TContext>();

            context.Database.Migrate();
        }
    }
}
