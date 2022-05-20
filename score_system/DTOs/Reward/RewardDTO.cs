using score_system.DTOs.Event;

namespace score_system.DTOs.Reward
{
    public class RewardDTO: RewardCreateDTO
    {
        public int Id { get; set; }
        public virtual ICollection<EventInfoDTO>? Events { get; set; }
    }
}
