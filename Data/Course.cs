using System.ComponentModel.DataAnnotations;

namespace efproje.Data;

public class Course
{
    [Key]
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;

}