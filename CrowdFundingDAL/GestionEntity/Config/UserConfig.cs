using CrowdFundingDAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CrowdFundingDAL.GestionEntity.Config
{
    
     public class UserConfig : IEntityTypeConfiguration<User>
     {

          public void Configure(EntityTypeBuilder<User> builder)
          {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Pseudo).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Pwd).IsRequired();    
            builder.Property(x=> x.IsAdmin).IsRequired();
            builder.HasCheckConstraint("CK_MAIL", "Mail like '__%@__%._%'");

          }
     }
}
