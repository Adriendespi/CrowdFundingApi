using CrowdFundingDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrowdFundingDAL.GestionEntity.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Commentary>
    {
        public void Configure(EntityTypeBuilder<Commentary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Text).IsRequired().HasMaxLength(500);
            
        }
    }
}
