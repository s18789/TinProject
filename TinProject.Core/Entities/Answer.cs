using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinProject.Core.Entities
{
    public class Answer : BaseEntity
    {
        public string OpenAnswer { get; set; }

        public bool? Answer1 { get; set; }

        public bool? Answer2 { get; set; }

        public bool? Answer3 { get; set; }

        public bool? Answer4 { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public Guid ExamResultUniqueId { get; set; }

        public ExamResult ExamResult { get; set; }
    }
}
