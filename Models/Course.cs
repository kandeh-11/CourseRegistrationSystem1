namespace CourseRegistrationSystem.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

        private int maxSeats;
        public int MaxSeats
        {
            get { return maxSeats; }
            private set
            {
                if (value > 0)
                {
                    maxSeats = value;
                }
                else
                {
                    maxSeats = 1; // default safe value
                }
            }
        }

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