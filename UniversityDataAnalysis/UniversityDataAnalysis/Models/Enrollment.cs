namespace UniversityDataAnalysis.Models;

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public bool IsActive { get; set; }
    public double? FinalGrade { get; set; }

    public override string ToString()
    {
        string gradeText = FinalGrade.HasValue
            ? FinalGrade.Value.ToString("0.0")
            : "no grade";

        return $"{Id}: StudentId={StudentId}, CourseId={CourseId}, Active={IsActive}, Grade={gradeText}";
    }
}