using System;

namespace InitTrackerApp.API.Models
{
    public class MonsterGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}