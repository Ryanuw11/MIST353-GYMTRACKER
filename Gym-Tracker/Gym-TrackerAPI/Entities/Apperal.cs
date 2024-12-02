using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerAPI.Entities
{
    //see README for ChatGPT prompt. Converting MySQL to asp.net
    public class Apperal
    {
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
