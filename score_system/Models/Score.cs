using System;
using System.Collections.Generic;

namespace score_system
{
    public partial class Score
    {
        public int ScoreId { get; set; }
        public int? CompetitorId { get; set; }
        public DateOnly? DateScore { get; set; }
        public decimal? Score1 { get; set; }
        public int? EventId { get; set; }
        public int? Status { get; set; }

        public virtual Competitor? Competitor { get; set; }
        public virtual Event? Event { get; set; }
    }
}
