using System.ComponentModel.DataAnnotations;

namespace efproje.Data;

public class Student
{
    [Key]
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? Phone{ get; set; }
}
