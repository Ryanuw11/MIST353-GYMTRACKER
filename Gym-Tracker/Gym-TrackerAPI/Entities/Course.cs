using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GymTrackersAPI.Entities
{
    public class Course
    {
        public int CID { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(255)]
        public int LengthMinutes { get; set; }

        [Required]
        [StringLength(255)]
        public string TrainerFirstName { get; set; }


        [Required]
        [StringLength(255)]
        public string TrainerLastName { get; set; }


        [Required]
        [StringLength(255)]
        public int Price { get; set; }



    }
}
