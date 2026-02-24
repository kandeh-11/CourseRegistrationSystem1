using System;
using System.Collections.Generic;
using CourseRegistrationSystem.Models;

namespace CourseRegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of courses
            List<Course> courses = new List<Course>
            {
                new Course("CIS101", "Introduction to Programming", 30),
                new Course("MATH201", "Calculus I", 25),
                new Course("ENG150", "English Composition", 20)
            };

            // Display courses
            Console.WriteLine("Available Courses:\n");

            foreach (Course course in courses)
            {
                Console.WriteLine($"{course.CourseCode} - {course.CourseName} (Seats: {course.MaxSeats})");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}