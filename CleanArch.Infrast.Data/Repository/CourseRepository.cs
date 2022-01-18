using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrast.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrast.Data.Repository
{
    public class CourseRepository : ICourseRpository
    {
        private UnivercityDbContext _ctx;

        public CourseRepository(UnivercityDbContext ctx)
        {
            _ctx = ctx;
        }

        public Course GetCourseById(int id)
        {
            return _ctx.Courses.Find(id);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
