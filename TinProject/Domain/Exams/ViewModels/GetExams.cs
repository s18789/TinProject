using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinProject.Main.Domain.Exams.ViewModels
{
    public class GetExams : IRequest<IEnumerable<ExamsViewModel>>
    {
    }
}
