namespace score_system.Repositories.EF
{
    public class EFTeamRepository : EFRepository<Team, DBScoreContext>, ITeamRepository
    {
        private readonly DBScoreContext context;
        public EFTeamRepository(DBScoreContext context) : base(context)
        {
            this.context = context;
        }
    }
}
