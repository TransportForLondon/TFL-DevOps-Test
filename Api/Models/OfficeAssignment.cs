using System.ComponentModel.DataAnnotations;

namespace TFL.DevOps.Api.Models;

public class OfficeAssignment
{
    [Key]
    public long InstructorID {get;set;}
    public string? Location {get;set;}

    public Instructor? Instructor {get;set;}
}