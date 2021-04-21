using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
