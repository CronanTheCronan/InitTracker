namespace InitTrackerApp.API.Models
{
    public class Creature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArmorClass { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int Condition { get; set; }
    }
}