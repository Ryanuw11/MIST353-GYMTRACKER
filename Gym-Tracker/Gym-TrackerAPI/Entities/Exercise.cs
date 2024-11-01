using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GymTrackersAPI.Entities
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
