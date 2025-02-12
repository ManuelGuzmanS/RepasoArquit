using Microsoft.EntityFrameworkCore;
using RepasoArquit.Shared.Entities;

namespace RepasoArquit.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
