namespace score_system.Repositories.EF
{
    public class EFScoreRepository : EFRepository<Score, DBScoreContext>, IScoreRepository
    {
        private readonly DBScoreContext context;
        public EFScoreRepository(DBScoreContext context) : base(context)
        {
            this.context = context;
        }
    }
}
