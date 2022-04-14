using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinProject.Main.Domain.Exams.ViewModels;

namespace TinProject.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ExamsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Exams()
        {
            var exams = await this.mediator.Send(new GetExams());

            return this.Ok(exams);
        }
    }
}
