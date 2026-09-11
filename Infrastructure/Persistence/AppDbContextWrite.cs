using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public sealed class AppDbContextWrite : DbContext, IAppDbcontext
{
    public AppDbContextWrite(DbContextOptions<AppDbContextWrite> options)
        : base(options)
    {
    }

    public DbSet<AppUser> AppUsers => Set<AppUser>();

    public DbSet<Company> Companies => Set<Company>();

    public DbSet<CompanyActivityLog> CompanyActivityLogs => Set<CompanyActivityLog>();

    public DbSet<GlobalActivityLog> GlobalActivityLogs => Set<GlobalActivityLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContextWrite).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}