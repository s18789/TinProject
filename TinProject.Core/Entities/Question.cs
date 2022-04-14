using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinProject.Core.Entities
{
    public class Question : BaseEntity
    {
        public string QuestionContext { get; set; }

        public string Description { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        public bool IsOpen { get; set; }

        public bool IsCorrectAnswer1 { get; set; }

        public bool IsCorrectAnswer2 { get; set; }

        public bool IsCorrectAnswer3 { get; set; }

        public bool IsCorrectAnswer4 { get; set; }

        public IEnumerable<ExamQuestion> ExamQuestions { get; set; }

        public IEnumerable<Answer> Answers { get; set; }
    }
}
