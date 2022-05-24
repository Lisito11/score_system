using score_system.Helpers;

namespace score_system.Repositories
{
    public interface IScoreRepository
    {
        public Task<PaginationGeneric<Score>>? GetScoreByEvent(int eventId, string typeOrder = "asc", int page = 1, int registerForPage = 10);

        public Task<PaginationGeneric<Score>>? GetScoreByEventToday(int eventId,string typeOrder = "asc", int page = 1, int registerForPage = 10);

        public Task<PaginationGeneric<Score>>? GetScoreByEventDate(int eventId, DateTime eventDate,string typeOrder = "asc", int page = 1, int registerForPage = 10);

    }
}
