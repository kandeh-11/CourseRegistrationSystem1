namespace CourseRegistrationSystem.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int MaxSeats { get; set; }

        public int EnrolledCount { get; set; }

        public Course(string courseCode, string courseName, int maxSeats)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            MaxSeats = maxSeats;
            EnrolledCount = 0;
        }
    }
}