using UniversityDataAnalysis.Data;
using UniversityDataAnalysis.Exercises;

namespace UniversityDataAnalysis;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== University Data Analysis ===");
            Console.WriteLine("0. Show all data");
            Console.WriteLine("1. Students from Warsaw");
            Console.WriteLine("2. Student email addresses");
            Console.WriteLine("3. Students sorted alphabetically");
            Console.WriteLine("9. Exit");
            Console.Write("Choose option: ");

            string? option = Console.ReadLine();

            Console.WriteLine();

            switch (option)
            {
                case "0":
                    ShowAllData();
                    break;

                case "1":
                    PrintResults(LinqExercises.GetStudentsFromWarsaw());
                    break;

                case "2":
                    PrintResults(LinqExercises.GetStudentEmails());
                    break;

                case "3":
                    PrintResults(LinqExercises.GetStudentsSortedAlphabetically());
                    break;

                case "9":
                    return;

                default:
                    Console.WriteLine("Unknown option.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static void ShowAllData()
    {
        Console.WriteLine("STUDENTS:");
        foreach (var student in UniversityData.Students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();
        Console.WriteLine("LECTURERS:");
        foreach (var lecturer in UniversityData.Lecturers)
        {
            Console.WriteLine(lecturer);
        }

        Console.WriteLine();
        Console.WriteLine("COURSES:");
        foreach (var course in UniversityData.Courses)
        {
            Console.WriteLine(course);
        }

        Console.WriteLine();
        Console.WriteLine("ENROLLMENTS:");
        foreach (var enrollment in UniversityData.Enrollments)
        {
            Console.WriteLine(enrollment);
        }
    }

    static void PrintResults(IEnumerable<string> results)
    {
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }
}