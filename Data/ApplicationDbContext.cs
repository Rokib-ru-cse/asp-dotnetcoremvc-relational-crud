using Aspdotnetmcvcrud.Models;
using Microsoft.EntityFrameworkCore;

namespace Aspdotnetmcvcrud.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }

    public DbSet<Category> Categories{get;set;}
}
