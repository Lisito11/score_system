using System;
using System.Collections.Generic;

namespace score_system
{
    public partial class Competitor
    {
        public Competitor()
        {
            Scores = new HashSet<Score>();
        }

        public int CompetitorId { get; set; }
        public string? NameCompetitor { get; set; }
        public int? TeamId { get; set; }
        public int? Status { get; set; }
        public string? Code { get; set; }

        public virtual Team? Team { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
