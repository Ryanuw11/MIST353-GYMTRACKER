namespace Gym_TrackerAPI.Data
//class to reference the nullible values from the exercise table
{
    public partial class ExtExercise
    {
        public string Name { get; set; } = null!;
        public string Equipment { get; set; } = null!;
        public string MuscleTarget { get; set; } = null!;
    }
}
