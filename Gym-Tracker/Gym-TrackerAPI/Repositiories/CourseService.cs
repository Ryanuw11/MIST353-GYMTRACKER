using Gym_TrackerAPI.Data;
using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

//Adding class price to the API

namespace Gym_TrackerAPI.Repositories
{
    //interface for CourseService
    public class CourseService : ICourseService
    {
        private readonly CourseData CourseData;

        public CourseService(CourseData CourseData)
        {
            CourseData = CourseData;
        }

        public Task<List<Course>> ClassP(int @ClassPrice)
        {
            throw new NotImplementedException();
        }


    }
}