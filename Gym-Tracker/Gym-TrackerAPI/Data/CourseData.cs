using System;
using System.Collections.Generic;


namespace Gym_TrackerJMAPI.Data
{
    //Adding  course data
    public partial class CourseData
    {
        public string CourseName { get; set; } = null!;
        public int LengthMinutes { get; set; }
        public string TrainerFirstName { get; set; } = null!;
        public string TrainerLastName { get; set; } = null!;
        public int ClassPrice { get; set; }


    }
}