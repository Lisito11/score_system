using score_system.Helpers;
using System;
using System.Collections.Generic;

namespace score_system
{
    public partial class Competitor: IId
    {
        public Competitor()
        {
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public string? NameCompetitor { get; set; }
        public int? TeamId { get; set; }
        public int? Status { get; set; }
        public string? Code { get; set; }

        public virtual Team? Team { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
