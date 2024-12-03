using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerDKAPI.Entities
{
    public class Apperal
    {
        [Key]
        public int ApparelId { get; set; }

        [Required]
        [StringLength(255)]
        public string ApparelType { get; set; }

        [Required]
        [StringLength(255)]
        public string ApparelBrand { get; set; }

        [Required]
        [StringLength(255)]
        public string ApparelMaterial { get; set; }

        [Required]
        public int ApparelExercise { get; set; }
    }
}
