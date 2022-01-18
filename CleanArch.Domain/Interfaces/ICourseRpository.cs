using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRpository
    {
        IEnumerable<Course> GetCourses();
    }
}
