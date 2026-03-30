namespace UniversityDataAnalysis.Models;

public class Student
{
    public int Id { get;  set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return $"{Id}: {FirstName} {LastName}, {City}, {Email}";
    }
}