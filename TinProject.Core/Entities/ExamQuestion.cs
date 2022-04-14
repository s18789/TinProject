using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinProject.Core.Entities
{
    public class ExamQuestion
    {
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public int Importance { get; set; }
    }
}
