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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(150);
            builder.Property(x => x.LastName).HasMaxLength(150);
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.PhoneNumber).HasMaxLength(13);
            builder.Property(x => x.Login).HasMaxLength(150);
            builder.Property(x => x.Password).HasMaxLength(150);
        }
    }
}
