using System.ComponentModel.DataAnnotations;

namespace efproje.Data;

public class CourseRegistration
{
    [Key]
    public int RegistrationId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.Now;

}