namespace score_system.DTOs.Event
{
    public class EventCreateDTO
    {
        public string? NameEvent { get; set; }
        public DateOnly? DateStart { get; set; }
        public DateOnly? DateEnd { get; set; }
        public int? RewardId { get; set; }
        public int? Status { get; set; }
    }

}
