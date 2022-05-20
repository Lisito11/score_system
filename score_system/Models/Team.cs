using score_system.Helpers;
using System;
using System.Collections.Generic;

namespace score_system
{
    public partial class Team : IId
    {
        public Team()
        {
            Competitors = new HashSet<Competitor>();
        }

        public int Id { get; set; }
        public string? NameTeam { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Competitor> Competitors { get; set; }
    }
}
