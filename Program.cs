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

            // Create a student
            Student student = new Student("S1", "Ousman");

            // Menu loop
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. View Courses");
                Console.WriteLine("2. Register for Course");
                Console.WriteLine("3. Drop Course");
                Console.WriteLine("4. View My Courses");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\nAvailable Courses:\n");

                    foreach (Course course in courses)
                    {
                        Console.WriteLine($"{course.CourseCode} - {course.CourseName} ({course.EnrolledCount}/{course.MaxSeats})");
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Course Code: ");
                    string code = Console.ReadLine();

                    Course selectedCourse = courses.Find(c => c.CourseCode == code);

                    if (selectedCourse == null)
                    {
                        Console.WriteLine("Course not found.");
                    }
                    else if (selectedCourse.EnrolledCount >= selectedCourse.MaxSeats)
                    {
                        Console.WriteLine("Course is full.");
                    }
                    else if (student.RegisteredCourses.Contains(selectedCourse))
                    {
                        Console.WriteLine("You are already registered in this course.");
                    }
                    else
                    {
                        student.RegisteredCourses.Add(selectedCourse);
                        selectedCourse.EnrolledCount++;

                        Console.WriteLine("Successfully registered!");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter Course Code to drop: ");
                    string code = Console.ReadLine();

                    Course courseToDrop = student.RegisteredCourses.Find(c => c.CourseCode == code);

                    if (courseToDrop == null)
                    {
                        Console.WriteLine("You are not registered in this course.");
                    }
                    else
                    {
                        student.RegisteredCourses.Remove(courseToDrop);
                        courseToDrop.EnrolledCount--;

                        Console.WriteLine("Course dropped successfully.");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("\nMy Courses:\n");

                    if (student.RegisteredCourses.Count == 0)
                    {
                        Console.WriteLine("You are not registered in any courses.");
                    }
                    else
                    {
                        foreach (Course c in student.RegisteredCourses)
                        {
                            Console.WriteLine($"{c.CourseCode} - {c.CourseName}");
                        }
                    }
                }
                else if (choice == "5")
                {
                    break;
                }
            }
        }
    }
}