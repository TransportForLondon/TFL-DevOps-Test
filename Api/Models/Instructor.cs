namespace TFL.DevOps.Api.Models;

public class Instructor
{
    public long Id { get; set; }
    public string? FirstMidName {get; set;}
    public string? LastName {get;set;}
    public DateTime? HireDate { get; set; }

    public ICollection<CourseAssignment> CourseAssignments {get; set;}
    public OfficeAssignment OfficeAssignment { get; set; }
}