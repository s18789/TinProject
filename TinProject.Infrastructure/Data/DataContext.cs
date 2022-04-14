using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinProject.Core.Entities;

namespace TinProject.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<ExamQuestion> ExamQuestions { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<ExamResult> ExamResults { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
