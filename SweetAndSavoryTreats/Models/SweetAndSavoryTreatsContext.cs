using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetAndSavoryTreats.Models
{
  public class SweetAndSavoryTreatsContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public virtual DbSet<Flavor> Flavors { get; set; }
    public virtual DbSet<FlavorTreat> FlavorTreats { get; set; }

    public SweetAndSavoryTreatsContext(DbContextOptions options): base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}