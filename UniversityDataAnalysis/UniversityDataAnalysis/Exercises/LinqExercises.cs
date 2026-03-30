using UniversityDataAnalysis.Data;

namespace UniversityDataAnalysis.Exercises;

public static class LinqExercises
{
    public static IEnumerable<string> GetStudentsFromWarsaw()
    {
        return UniversityData.Students
            .Where(student => student.City == "Warsaw")
            .Select(student => $"{student.FirstName} {student.LastName}");
    }

    public static IEnumerable<string> GetStudentEmails()
    {
        return UniversityData.Students
            .Select(student => student.Email);
    }

    public static IEnumerable<string> GetStudentsSortedAlphabetically()
    {
        return UniversityData.Students
            .OrderBy(student => student.FirstName)
            .ThenBy(student => student.LastName)
            .Select(student => $"{student.FirstName} {student.LastName}");
    }
}