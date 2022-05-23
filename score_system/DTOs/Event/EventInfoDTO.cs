using score_system.DTOs.Reward;

namespace score_system.DTOs.Event
{
    public class EventInfoDTO
    {
        public string? NameEvent { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public virtual RewardInfoDTO? Reward { get; set; }
    }
}
