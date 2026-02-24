namespace CourseRegistrationSystem.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }

        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
    }
}