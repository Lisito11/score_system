namespace score_system.Repositories.EF
{
    public class EFEventRepository : EFRepository<Event, DBScoreContext>, IEventRepository
    {
        private readonly DBScoreContext context;
        public EFEventRepository(DBScoreContext context) : base(context)
        {
            this.context = context;
        }
    }
}
