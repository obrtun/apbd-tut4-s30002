namespace UniversityDataAnalysis.Models;

public class Lecturer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    
    public override string ToString()
    {
        return $"{Id}: {FullName}";
    }
}