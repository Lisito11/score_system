using score_system.DTOs.Team;

namespace score_system.DTOs
{
    public class CompetitorInfoDTO
    {
        public string? Code { get; set; }
        public string? NameCompetitor { get; set; }
        public virtual TeamInfoDTO? Team { get; set; }

    }
}
