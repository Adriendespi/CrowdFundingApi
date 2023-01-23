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
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MDN4PLH;Initial Catalog=CrowdFunding;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.Entity<UserProjectMTM>().HasKey(x => new { x.UId, x.PId });

        }
    }
}
