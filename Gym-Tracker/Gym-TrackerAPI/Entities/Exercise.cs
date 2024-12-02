using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerAPI.Entities
//see README for ChatGPT prompt. Converting MySQL to asp.net
{
    public class Exercise
    {
        public int ExerciseId { get; set; }

        [Required]
        [StringLength(255)]
        public string ExerciseName { get; set; }

        [StringLength(255)]
        public string? ExerciseEquipment { get; set; }

        [Required]
        [StringLength(255)]
        public string ExerciseMuscleTarget { get; set; }
    }
}
