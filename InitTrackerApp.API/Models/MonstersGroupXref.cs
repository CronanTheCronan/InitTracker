using System;
using System.Collections.Generic;

namespace InitTrackerApp.API.Models
{
    public partial class MonstersGroupXref
    {
        public int Id { get; set; }
        public int MonsterId { get; set; }
        public int MonsterExtId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
    }
}
