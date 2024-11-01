using Gym_TrackerJMAPI.Data;
using Gym_TrackerJMAPI.Entities;
using GymTrackersAPI.Repositiories;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

//Adding class price to the API

namespace Gym_TrackerJMAPI.Repositories
{
    //interface for CourseService
    public class CourseService : ICourseService
    {
        private readonly CourseData  _CourseData;

        public CourseService(CourseData CourseData)
        {
            _CourseData = CourseData;
        }

        public Task<List<Course>> ClassP(int @ClassPrice)
        {
            throw new NotImplementedException();
        }

  
        }
    }

