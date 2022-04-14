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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.Property(x => x.OpenAnswer).HasMaxLength(4000);

            builder.HasOne(o => o.Question)
                .WithMany(m => m.Answers)
                .HasForeignKey(fk => fk.QuestionId);

            builder.HasOne(o => o.ExamResult)
                .WithMany(m => m.Answers)
                .HasForeignKey(fk => fk.ExamResultUniqueId);
        }
    }
}
