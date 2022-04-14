using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinProject.Core.Entities
{
    public class ExamResult
    {
        public Guid UniqueId { get; set; }

        public DateTime StartExamDateTime { get; set; }

        public DateTime FinishExamDateTime { get; set; }

        public double Score { get; set; }

        public string Description { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public IEnumerable<Answer> Answers { get; set; }
    }
}
