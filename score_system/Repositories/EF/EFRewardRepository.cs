namespace score_system.Repositories.EF
{
    public class EFRewardRepository: EFRepository<Reward, DBScoreContext>, IRewardRepository
    {
        private readonly DBScoreContext context;
        public EFRewardRepository(DBScoreContext context) : base(context)
        {
            this.context = context;
        }
    }
}
