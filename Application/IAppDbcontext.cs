using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application;

public interface IAppDbcontext
{
    public DbSet<AppUser> AppUsers { get; }

    public DbSet<Company> Companies { get; }
}