namespace TFL.DevOps.Api.Models;

public enum Grade
{
    A, B, C, D, F
}

public class Enrollment
{
    public long EnrollmentId {get;set;}
    public long CourseId {get;set;}
    public long StudentID {get;set;}
    public Grade? Grade {get;set;}

    public Course? Course {get;set;}
    public Student? Student {get;set;}
}