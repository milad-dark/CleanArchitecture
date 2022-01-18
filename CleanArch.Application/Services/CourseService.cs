using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRpository _courseRpository;

        public CourseService(ICourseRpository courseRpository)
        {
            _courseRpository = courseRpository;
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
