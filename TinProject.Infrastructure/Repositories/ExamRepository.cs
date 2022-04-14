using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinProject.Core.Entities;
using TinProject.Infrastructure.Data;
using TinProject.Infrastructure.Interfaces;

namespace TinProject.Infrastructure.Repositories
{
    public class ExamRepository : EfRepository<Exam>, IExamRepository
    {
        public ExamRepository(DataContext context)
            : base(context)
        {
        }
    }
}
