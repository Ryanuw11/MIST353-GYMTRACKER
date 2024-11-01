using GymTrackersAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace GymTrackersAPI.Data
    //class to reference the nullible values from the exercise table
{
    public partial class ExtExercise
    {
        public string Name { get; set; } = null!;
        public string Equipment { get; set; } = null!;
        public string MuscleTarget { get; set; } = null!;
    }
}
