using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Gym_TrackerDKAPI.Data
{
    public partial class ExtExercise
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Equipment { get; set; } = null!;
        public string MuscleTarget { get; set; } = null!;
    }
}
