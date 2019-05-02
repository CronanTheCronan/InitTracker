using System;
using System.Collections.Generic;

namespace InitTrackerApp.API.Models
{
    public partial class Monsters
    {
        public Monsters()
        {
            MonstersExtended = new HashSet<MonstersExtended>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Alignment { get; set; }
        public int RecAc { get; set; }
        public int RecHp { get; set; }
        public int ChallengeRating { get; set; }
        public bool Homebrew { get; set; }
        public int? Content { get; set; }
        public int CreatedByUser { get; set; }

        public virtual Users CreatedByUserNavigation { get; set; }
        public virtual ICollection<MonstersExtended> MonstersExtended { get; set; }
    }
}
