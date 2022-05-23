using score_system.Helpers;
using System;
using System.Collections.Generic;

namespace score_system
{
    public partial class Event : IId
    {
        public Event()
        {
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public string? NameEvent { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? RewardId { get; set; }
        public int? Status { get; set; }

        public virtual Reward? Reward { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
