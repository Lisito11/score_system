using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using score_system.DTOs;
using score_system.Repositories.EF;

namespace score_system.Controllers
{
    [Route("api/competitor")]
    [ApiController]
    public class CompetitorController : CustomBaseController<Competitor, CompetitorDTO, CompetitorCreateDTO, EFCompetitorRepository>
    {
        public CompetitorController(EFCompetitorRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
