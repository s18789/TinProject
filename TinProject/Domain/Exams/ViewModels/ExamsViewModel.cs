using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinProject.Main.Domain.Exams.ViewModels
{
    public class ExamsViewModel
    {
        public string Title { get; set; }

        public int Time { get; set; }

        public DateTime CreationDate { get; set; }

        public int MaxPoints { get; set; }
    }
}
