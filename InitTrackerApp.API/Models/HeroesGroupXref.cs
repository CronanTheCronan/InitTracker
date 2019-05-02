using System;
using System.Collections.Generic;

namespace InitTrackerApp.API.Models
{
    public partial class HeroesGroupXref
    {
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int HeroExtId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }

        public virtual HeroGroups Group { get; set; }
        public virtual Heroes Hero { get; set; }
        public virtual HeroesExtended HeroExt { get; set; }
        public virtual Users User { get; set; }
    }
}
