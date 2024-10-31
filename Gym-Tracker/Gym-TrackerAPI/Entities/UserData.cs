using System.ComponentModel.DataAnnotations;

namespace GymTrackersAPI.Entities
{
    public class UserData
    {
       



    
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserPassword { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string UserEmail { get; set; }

        [StringLength(200)]
        public string UserAddress { get; set; }

        [StringLength(100)]
        public string UserCity { get; set; }

        public DateTime UserJoined { get; set; } = DateTime.UtcNow; 

        [Range(1, 10)] 
        public int UserLevel { get; set; }
    }
}

