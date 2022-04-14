using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TinProject.Infrastructure.Interfaces;
using TinProject.Main.Domain.Exams.ViewModels;

namespace TinProject.Main.Domain.Exams.Handlers
{
    public class GetExamsHandler : IRequestHandler<GetExams, IEnumerable<ExamsViewModel>>
    {
        private readonly IExamRepository examRepository;

        public GetExamsHandler(IExamRepository examRepository)
        {
            this.examRepository = examRepository;
        }

        public async Task<IEnumerable<ExamsViewModel>> Handle(GetExams request, CancellationToken cancellationToken)
        {
            var exams = await this.examRepository.ListAllAsync();

            return exams.Select(x => new ExamsViewModel
            {
                Title = x.Title,
                Time = x.Time,
                CreationDate = x.CreationDate,
                MaxPoints = x.MaxPoints
            });
        }
    }
}
