using System;

namespace InitTrackerApp.API.Models
{
    public class MonsterExtended
    {
        public int Id { get; set; }
        public int MonsterId { get; set; }
        public int ArmorClass { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int? Condition1 { get; set; }
        public int? Condition2 { get; set; }
        public int? Condition3 { get; set; }
        public int? Condition4 { get; set; }
        public int CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}