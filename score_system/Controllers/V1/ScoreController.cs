using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using score_system.DTOs.Score;
using score_system.Repositories.EF;

namespace score_system.Controllers.V1
{
    [Route("api/score")]
    [ApiController]
    public class ScoreController : CustomBaseController<Score, ScoreDTO, ScoreCreateDTO, EFScoreRepository>
    {
        public ScoreController(EFScoreRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
