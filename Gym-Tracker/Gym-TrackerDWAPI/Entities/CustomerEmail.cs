using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerDWAPI.Entities
{
    public class CustomerEmail
    {
        [Key]
        public string Email { get; set; }

        public CustomerEmail() { } 

        public CustomerEmail(string email)
        {
            Email = email;
        }
    }
}
