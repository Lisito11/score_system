using score_system.DTOs.Reward;

namespace score_system.DTOs.Event
{
    public class EventInfoDTO
    {
        public string? NameEvent { get; set; }
        public DateOnly? DateStart { get; set; }
        public DateOnly? DateEnd { get; set; }
        public virtual RewardInfoDTO? Reward { get; set; }
    }
}
