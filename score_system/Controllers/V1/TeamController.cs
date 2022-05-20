using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using score_system.DTOs.Team;
using score_system.Repositories.EF;

namespace score_system.Controllers.V1
{
    [Route("api/team")]
    [ApiController]
    public class TeamController : CustomBaseController<Team, TeamDTO, TeamCreateDTO, EFTeamRepository>
    {
        public TeamController(EFTeamRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
