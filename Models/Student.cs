using efproje.Data;

namespace efproje.Models;

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
        public ICollection<CourseRegistration> Registrations { get; set; } = new List<CourseRegistration>();
    }
