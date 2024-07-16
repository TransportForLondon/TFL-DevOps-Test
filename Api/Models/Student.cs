namespace TFL.DevOps.Api.Models;

public class Student
{
    public long Id {get; set;}
    public string? FirstMidName { get; set; }
    public string? LastName { get; set; }
    public DateTime? EnrollmentDate { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
}