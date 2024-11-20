using System.ComponentModel.DataAnnotations;

// Adding what belongs in membership in sql into the API

namespace Gym_TrackerJMAPI.Entities
{
    public class Membership
    {

        public int ID { get; set; }
        public required string MembershipLevel { get; set; }

        public int MembershipMonthPrice {get; set;}
        public int MembershipMonthLength { get; set; }
    }
}

