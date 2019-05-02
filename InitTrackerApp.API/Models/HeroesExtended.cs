using System;
using System.Collections.Generic;

namespace InitTrackerApp.API.Models
{
    public partial class HeroesExtended
    {
        public HeroesExtended()
        {
            HeroesGroupXref = new HashSet<HeroesGroupXref>();
        }

        public int Id { get; set; }
        public int HeroId { get; set; }
        public int ArmorClass { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int? Condition1 { get; set; }
        public int? Condition2 { get; set; }
        public int? Condition3 { get; set; }
        public int? Condition4 { get; set; }

        public virtual Heroes Hero { get; set; }
        public virtual ICollection<HeroesGroupXref> HeroesGroupXref { get; set; }
    }
}
