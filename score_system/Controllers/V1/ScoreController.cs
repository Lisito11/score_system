using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using score_system.DTOs.Score;
using score_system.Helpers;
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

        [HttpGet("event")]
        public async Task<ActionResult<PaginationGeneric<ScoreCompetitorInfoDTO>>>? GetScoreByEvent(int eventId, string typeOrder = "asc", int page = 1, int registerForPage = 10)
        {
            var entity = await _repository.GetScoreByEvent(eventId, typeOrder, page, registerForPage)!;
            if (entity == null)
            {
                return NotFound("Ha ocurrido un error al lanzar los datos");
            }
            var dto = _mapper.Map<PaginationGeneric<ScoreCompetitorInfoDTO>>(entity);
            return dto;

        }

        [HttpGet("event/today")]
        public async Task<ActionResult<PaginationGeneric<ScoreCompetitorInfoDTO>>>? GetScoreByEventToday(int eventId, string typeOrder = "asc", int page = 1, int registerForPage = 10)
        {
            var entity = await _repository.GetScoreByEventToday(eventId, typeOrder, page, registerForPage)!;
            if (entity == null)
            {
                return NotFound("Ha ocurrido un error al lanzar los datos");
            }
            var dto = _mapper.Map<PaginationGeneric<ScoreCompetitorInfoDTO>>(entity);
            return dto;

        }
        [HttpGet("event/date")]
        public async Task<ActionResult<PaginationGeneric<ScoreCompetitorInfoDTO>>>? GetScoreByEventDate(int eventId, DateTime eventDate, string typeOrder = "asc", int page = 1, int registerForPage = 10)
        {
            var entity = await _repository.GetScoreByEventDate(eventId, eventDate,typeOrder, page, registerForPage)!;
            if (entity == null)
            {
                return NotFound("Ha ocurrido un error al lanzar los datos");
            }
            var dto = _mapper.Map<PaginationGeneric<ScoreCompetitorInfoDTO>>(entity);
            return dto;

        }

    }
}
