using System;

namespace InitTrackerApp.API.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}