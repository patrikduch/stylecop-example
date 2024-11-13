namespace StyleCopExample.Persistence.Contexts;

using Domain.Entities;
using EntityConfigurations;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Adding configuration rules to the <seealso cref="ApplicationDbContext"/>.
    /// </summary>
    /// <param name="modelBuilder"><seealso cref="ModelBuilder"/> object for extending current <seealso cref="ApplicationDbContext"/> object.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
    }

    public DbSet<Order> Orders { get; set; }
}