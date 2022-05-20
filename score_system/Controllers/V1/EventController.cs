using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using score_system.DTOs.Event;
using score_system.Repositories.EF;

namespace score_system.Controllers.V1
{
    [Route("api/event")]
    [ApiController]
    public class EventController : CustomBaseController<Event, EventDTO, EventCreateDTO, EFEventRepository>
    {
        public EventController(EFEventRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
