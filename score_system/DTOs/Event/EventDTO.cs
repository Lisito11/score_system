using score_system.DTOs.Reward;
using score_system.DTOs.Score;

namespace score_system.DTOs.Event
{
    public class EventDTO: EventCreateDTO
    {
        public int Id { get; set; }
        public virtual RewardInfoDTO? Reward { get; set; }
        public virtual ICollection<ScoreInfoDTO>? Scores { get; set; }
    }
}
