namespace score_system.DTOs.Score
{
    public class ScoreCreateDTO
    {
        public int? CompetitorId { get; set; }
        public DateTime? DateScore { get; set; }
        public decimal? Score1 { get; set; }
        public int? EventId { get; set; }
        public int? Status { get; set; }
    }
}
