namespace UniversityDataAnalysis.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public int LecturerId { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Name}, starts {StartDate:yyyy-MM-dd}, LecturerId={LecturerId}";
    }
}