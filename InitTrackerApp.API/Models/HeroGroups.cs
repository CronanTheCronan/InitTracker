using System;
using System.Collections.Generic;

namespace InitTrackerApp.API.Models
{
    public partial class HeroGroups
    {
        public HeroGroups()
        {
            HeroesGroupXref = new HashSet<HeroesGroupXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HeroesGroupXref> HeroesGroupXref { get; set; }
    }
}
