using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinProject.Core.Entities
{
    public class Exam : BaseEntity
    {
        public string Title { get; set; }

        public int Time { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public int MaxPoints { get; set; }

        public IEnumerable<ExamQuestion> ExamQuestions { get; set; }

        public IEnumerable<ExamResult> ExamResults { get; set; }
    }
}
