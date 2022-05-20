using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using score_system.DTOs.Reward;
using score_system.Repositories.EF;

namespace score_system.Controllers.V1
{
    [Route("api/reward")]
    [ApiController]
    public class RewardController : CustomBaseController<Reward, RewardDTO, RewardCreateDTO, EFRewardRepository>
    {
        public RewardController(EFRewardRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
