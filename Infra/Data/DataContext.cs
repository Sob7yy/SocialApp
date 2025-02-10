using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
