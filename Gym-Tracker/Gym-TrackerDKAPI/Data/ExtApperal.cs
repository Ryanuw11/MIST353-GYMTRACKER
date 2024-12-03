namespace Gym_TrackerDKAPI.Data
{
    public class ExtApperal
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public string Material { get; set; } = null!;
        public virtual ExtExercise Exercise { get; set; } = null!;
    }
}
