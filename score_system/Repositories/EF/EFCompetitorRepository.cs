namespace score_system.Repositories.EF
{
    public class EFCompetitorRepository : EFRepository<Competitor, DBScoreContext>, ICompetitorRepository
    {
        private readonly DBScoreContext context;
        public EFCompetitorRepository(DBScoreContext context) : base(context)
        {
            this.context = context;
        }
    }
}
