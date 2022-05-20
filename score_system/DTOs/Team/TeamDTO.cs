namespace score_system.DTOs.Team
{
    public class TeamDTO: TeamCreateDTO
    {
        public int Id { get; set; }
        public virtual ICollection<CompetitorInfoDTO>? Competitors { get; set; }
    }
}
