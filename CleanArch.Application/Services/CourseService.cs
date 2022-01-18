using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRpository _courseRpository;

        public CourseService(ICourseRpository courseRpository)
        {
            _courseRpository = courseRpository;
        }

        public Course GetCourseById(int id)
        {
            Course course = _courseRpository.GetCourseById(id);
            return course;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRpository.GetCourses()
            };
        }
    }
}
