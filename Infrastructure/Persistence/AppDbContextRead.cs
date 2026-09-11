using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public sealed class AppDbContextRead : DbContext, IAppDbcontext
{
    public AppDbContextRead(DbContextOptions<AppDbContextRead> options)
        : base(options)
    {
    }

    public DbSet<AppUser> AppUsers => Set<AppUser>();

    public DbSet<Company> Companies => Set<Company>();

    public DbSet<CompanyActivityLog> CompanyActivityLogs => Set<CompanyActivityLog>();

    public DbSet<GlobalActivityLog> GlobalActivityLogs => Set<GlobalActivityLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContextRead).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}