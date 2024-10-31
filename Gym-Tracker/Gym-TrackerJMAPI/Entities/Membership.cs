using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerJMAPI.Entities
{
    public class Membership
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string MembershipLevel { get; set; }

        [Required]
        [StringLength(255)]
        public int MembershipMonthPrice { get; set; }

        [Required]
        [StringLength(255)]
        public int MembershipMonthLength { get; set; }

   
    }
}
