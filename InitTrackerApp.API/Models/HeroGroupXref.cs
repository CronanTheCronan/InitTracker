namespace InitTrackerApp.API.Models
{
    public class HeroGroupXref
    {
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int HeroExtId { get; set; }
        public int HeroGroupId { get; set; }
        public int UserId { get; set; }
    }
}