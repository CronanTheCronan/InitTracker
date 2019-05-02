using System;

namespace InitTrackerApp.API.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int AlignmentId { get; set; }
        public int RecAC { get; set; }
        public int RecHP { get; set; }
        public int ChallengeRating { get; set; }
        public bool Homebrew { get; set; }
        public int? ContentId { get; set; }
        public int CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}