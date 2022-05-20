using score_system.DTOs.Score;
using score_system.DTOs.Team;

namespace score_system.DTOs
{
    public class CompetitorDTO: CompetitorCreateDTO
    {
        public int Id { get; set; }
        public virtual TeamInfoDTO? Team { get; set; }
        public virtual ICollection<ScoreInfoDTO>? Scores { get; set; }
    }
}
