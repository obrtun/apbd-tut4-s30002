using System;
using UniversityDataAnalysis.Data;

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
            Console.WriteLine("9. Exit");
            Console.Write("Choose option: ");

            string? option = Console.ReadLine();

            Console.WriteLine();

            switch (option)
            {
                case "0":
                    ShowAllData();
                    break; 
                case "9":
                    return;

                default:
                    Console.WriteLine("Unknown option.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }

    static void ShowAllData()
    {
        Console.WriteLine("STUDENTS:");
        foreach (var s in UniversityData.Students)
            Console.WriteLine(s);

        Console.WriteLine("\nLECTURERS:");
        foreach (var l in UniversityData.Lecturers)
            Console.WriteLine(l);

        Console.WriteLine("\nCOURSES:");
        foreach (var c in UniversityData.Courses)
            Console.WriteLine(c);

        Console.WriteLine("\nENROLLMENTS:");
        foreach (var e in UniversityData.Enrollments)
            Console.WriteLine(e);
    }
}