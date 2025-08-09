using Microsoft.EntityFrameworkCore;

namespace _3DPrintStoreBackendAPI.Models;

public class PrintableContext : DbContext
{
    public PrintableContext(DbContextOptions<PrintableContext> options) : base(options) { }

    public DbSet<Printable> Printables { get; set; } = null;
}
