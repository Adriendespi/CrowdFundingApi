using CrowdFundingDAL.GestionEntity.Config;
using CrowdFundingDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CrowdFundingDAL.GestionEntity.context
{
    public class DataContext:DbContext
    {
        

        public DbSet<User> users { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Commentary> comments { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OAB0UHO;Database=CrowdFunding;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());

           

        }
    }
}
