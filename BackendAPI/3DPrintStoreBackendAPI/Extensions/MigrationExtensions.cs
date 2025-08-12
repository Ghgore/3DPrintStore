using _3DPrintStoreBackendAPI.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace _3DPrintStoreBackendAPI.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using SecurityDbContext context = scope.ServiceProvider.GetRequiredService<SecurityDbContext>();

            context.Database.Migrate();
        }
    }
}
