using Microsoft.EntityFrameworkCore;
using score_system.Helpers;

namespace score_system.Repositories.EF
{
    public class EFScoreRepository : EFRepository<Score, DBScoreContext>, IScoreRepository
    {
        private readonly DBScoreContext context;
        public EFScoreRepository(DBScoreContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<PaginationGeneric<Score>>? GetScoreByEvent(int eventId, string typeOrder = "asc", int page = 1, int registerForPage = 10)
        {
            //DateTime fecha = DateTime.Now;
            //string parsearFecha = fecha.ToString("yyyy-MM-dd");

            List<Score> scores;
            PaginationGeneric<Score> paginationScore;
            int _totalRegisters = 0;
            int _totalPages = 0;

            scores = await context.Scores.Include(x=> x.Competitor).Where(x => x.EventId == eventId).GroupBy(s => new {s.CompetitorId, s.Status}).Select(t=> new Score {CompetitorId = t.Key.CompetitorId, Score1 = t.Sum(s => s.Score1), Status = t.Key.Status, DateScore = DateTime.Now}).ToListAsync();

            if (typeOrder.ToLower() == "desc")
            {
                scores = scores.OrderByDescending(x => x.Score1).ToList();
            }
            else if (typeOrder.ToLower() == "asc")
            {
                scores = scores.OrderBy(x => x.Score1).ToList();
            }


            // Número total de registros de la tabla Customers
            _totalRegisters = scores.Count();

            // Obtenemos la 'página de registros' de la tabla Customers
            scores = scores.Skip((page - 1) * registerForPage)
                                             .Take(registerForPage)
                                             .ToList();


            // Número total de páginas de la tabla
            _totalPages = (int)Math.Ceiling((double)_totalRegisters / registerForPage);


            // Instanciamos la 'Clase de paginación' y asignamos los nuevos valores
            paginationScore = new PaginationGeneric<Score>()
            {
                RegistrosPorPagina = registerForPage,
                TotalRegistros = _totalRegisters,
                TotalPaginas = _totalPages,
                PaginaActual = page,
                TipoOrdenActual = typeOrder,
                Resultado = scores
            };

            return paginationScore;
        }

        public async Task<PaginationGeneric<Score>>? GetScoreByEventDate(int eventId, DateTime eventDate, string typeOrder = "asc", int page = 1, int registerForPage = 10)
        {
            List<Score> scores;
            PaginationGeneric<Score> paginationScore;
            int _totalRegisters = 0;
            int _totalPages = 0;

            scores = await context.Scores.Include(x => x.Competitor).Where(x => x.EventId == eventId && x.DateScore!.Value.Date == eventDate.Date).GroupBy(s => new { s.CompetitorId, s.Status, s.DateScore }).Select(t => new Score { CompetitorId = t.Key.CompetitorId, Score1 = t.Sum(s => s.Score1), Status = t.Key.Status, DateScore = t.Key.DateScore }).ToListAsync();

            if (typeOrder.ToLower() == "desc")
            {
                scores = scores.OrderByDescending(x => x.Score1).ToList();
            }
            else if (typeOrder.ToLower() == "asc")
            {
                scores = scores.OrderBy(x => x.Score1).ToList();
            }


            // Número total de registros de la tabla Customers
            _totalRegisters = scores.Count();

            // Obtenemos la 'página de registros' de la tabla Customers
            scores = scores.Skip((page - 1) * registerForPage)
                                             .Take(registerForPage)
                                             .ToList();


            // Número total de páginas de la tabla
            _totalPages = (int)Math.Ceiling((double)_totalRegisters / registerForPage);


            // Instanciamos la 'Clase de paginación' y asignamos los nuevos valores
            paginationScore = new PaginationGeneric<Score>()
            {
                RegistrosPorPagina = registerForPage,
                TotalRegistros = _totalRegisters,
                TotalPaginas = _totalPages,
                PaginaActual = page,
                TipoOrdenActual = typeOrder,
                Resultado = scores
            };

            return paginationScore;
        }

        public async Task<PaginationGeneric<Score>>? GetScoreByEventToday(int eventId, string typeOrder = "asc", int page = 1, int registerForPage = 10)
        {

            List<Score> scores;
            PaginationGeneric<Score> paginationScore;
            int _totalRegisters = 0;
            int _totalPages = 0;

            scores = await context.Scores.Include(x => x.Competitor).Where(x => x.EventId == eventId && x.DateScore!.Value.Date == DateTime.Now.Date).GroupBy(s => new { s.CompetitorId, s.Status, s.DateScore }).Select(t => new Score { CompetitorId = t.Key.CompetitorId, Score1 = t.Sum(s => s.Score1), Status = t.Key.Status, DateScore = t.Key.DateScore }).ToListAsync();

            if (typeOrder.ToLower() == "desc")
            {
                scores = scores.OrderByDescending(x => x.Score1).ToList();
            }
            else if (typeOrder.ToLower() == "asc")
            {
                scores = scores.OrderBy(x => x.Score1).ToList();
            }


            // Número total de registros de la tabla Customers
            _totalRegisters = scores.Count();

            // Obtenemos la 'página de registros' de la tabla Customers
            scores = scores.Skip((page - 1) * registerForPage)
                                             .Take(registerForPage)
                                             .ToList();


            // Número total de páginas de la tabla
            _totalPages = (int)Math.Ceiling((double)_totalRegisters / registerForPage);


            // Instanciamos la 'Clase de paginación' y asignamos los nuevos valores
            paginationScore = new PaginationGeneric<Score>()
            {
                RegistrosPorPagina = registerForPage,
                TotalRegistros = _totalRegisters,
                TotalPaginas = _totalPages,
                PaginaActual = page,
                TipoOrdenActual = typeOrder,
                Resultado = scores
            };

            return paginationScore;
        }

    }
}
