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
    public class ExamResultConfiguration : IEntityTypeConfiguration<ExamResult>
    {
        public void Configure(EntityTypeBuilder<ExamResult> builder)
        {
            builder.HasKey(k => k.UniqueId);
            builder.Property(x => x.Description).HasMaxLength(4000);

            builder.HasOne(o => o.Exam)
                .WithMany(m => m.ExamResults)
                .HasForeignKey(fk => fk.ExamId);

            builder.HasOne(o => o.Student)
                .WithMany(m => m.examResults)
                .HasForeignKey(fk => fk.ExamId);
        }
    }
}
