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
    public class ExamQuestionConfiguration : IEntityTypeConfiguration<ExamQuestion>
    {
        public void Configure(EntityTypeBuilder<ExamQuestion> builder)
        {
            builder.HasKey(k => new { k.ExamId, k.QuestionId});

            builder.HasOne(o => o.Exam)
                .WithMany(m => m.ExamQuestions)
                .HasForeignKey(fk => fk.ExamId);

            builder.HasOne(o => o.Question)
                .WithMany(m => m.ExamQuestions)
                .HasForeignKey(fk => fk.QuestionId);
        }
    }
}
