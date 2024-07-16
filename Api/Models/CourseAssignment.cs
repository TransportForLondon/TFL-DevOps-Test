namespace TFL.DevOps.Api.Models;

public class CourseAssignment
{
    public long InstructorID {get;set;}
    public long CourseID {get;set;}
    
    public Instructor? Instructor {get;set;}
    public Course? Course {get;set;} 
}