using System;
using System.Collections.Generic;

namespace score_system
{
    public partial class Reward
    {
        public Reward()
        {
            Events = new HashSet<Event>();
        }

        public int RewardId { get; set; }
        public string? NameReward { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
