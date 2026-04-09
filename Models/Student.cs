using System.Collections.Generic;

namespace CourseRegistrationSystem.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }

        public List<Course> RegisteredCourses { get; private set; }

        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
            RegisteredCourses = new List<Course>();
        }

        public bool AddCourse(Course course)
        {
            if (RegisteredCourses.Contains(course))
            {
                return false;
            }

            RegisteredCourses.Add(course);
            return true;
        }

        public bool RemoveCourse(Course course)
        {
            if (!RegisteredCourses.Contains(course))
            {
                return false;
            }

            RegisteredCourses.Remove(course);
            return true;
        }
    }
}