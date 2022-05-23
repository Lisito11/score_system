namespace score_system.DTOs.Event
{
    public class EventCreateDTO
    {
        public string? NameEvent { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? RewardId { get; set; }
        public int? Status { get; set; }
    }

}
