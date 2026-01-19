namespace efproje.Models
{
    public class CourseRegistration
    {
        public int CourseRegistrationId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime RegistrationDate { get; set; }
        
        public Course Course { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}