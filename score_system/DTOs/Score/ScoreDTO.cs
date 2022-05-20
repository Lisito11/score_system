using score_system.DTOs.Event;

namespace score_system.DTOs.Score
{
    public class ScoreDTO: ScoreCreateDTO
    {
        public int Id { get; set; }
        public virtual CompetitorInfoDTO? Competitor { get; set; }
        public virtual EventInfoDTO? Event { get; set; }
    }
}
