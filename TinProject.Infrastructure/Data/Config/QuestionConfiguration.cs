using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinProject.Core.Entities;

namespace TinProject.Infrastructure.Data.Config
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(x => x.QuestionContext).HasMaxLength(4000);
            builder.Property(x => x.Description).HasMaxLength(4000);
            builder.Property(x => x.Answer1).HasMaxLength(4000);
            builder.Property(x => x.Answer2).HasMaxLength(4000);
            builder.Property(x => x.Answer3).HasMaxLength(4000);
            builder.Property(x => x.Answer4).HasMaxLength(4000);
        }
    }
}
