using UniversityDataAnalysis.Models;

namespace UniversityDataAnalysis.Data;

public static class UniversityData
    {
        public static List<Student> Students { get; } = new List<Student>
        {
            new Student
            {
                Id = 1,
                FirstName = "Anna",
                LastName = "Kowalska",
                City = "Warsaw",
                Email = "anna@uni.test"
            },
            new Student
            {
                Id = 2,
                FirstName = "Piotr",
                LastName = "Nowak",
                City = "Krakow",
                Email = "piotr@uni.test"
            },
            new Student
            {
                Id = 3,
                FirstName = "Maria",
                LastName = "Wisniewska",
                City = "Warsaw",
                Email = "maria@uni.test"
            },
            new Student
            {
                Id = 4,
                FirstName = "Jan",
                LastName = "Zielinski",
                City = "Gdansk",
                Email = "jan@uni.test"
            },
            new Student
            {
                Id = 5,
                FirstName = "Ola",
                LastName = "Wojcik",
                City = "Poznan",
                Email = "ola@uni.test"
            }
        };

        public static List<Lecturer> Lecturers { get; } = new List<Lecturer>
        {
            new Lecturer
            {
                Id = 1,
                FullName = "Dr. Adam Nowicki"
            },
            new Lecturer
            {
                Id = 2,
                FullName = "Prof. Ewa Maj"
            },
            new Lecturer
            {
                Id = 3,
                FullName = "Dr. Tomasz Lewandowski"
            }
        };

        public static List<Course> Courses { get; } = new List<Course>
        {
            new Course
            {
                Id = 1,
                Name = "Databases",
                StartDate = new DateTime(2026, 4, 5),
                LecturerId = 1
            },
            new Course
            {
                Id = 2,
                Name = "Algorithms",
                StartDate = new DateTime(2026, 3, 15),
                LecturerId = 2
            },
            new Course
            {
                Id = 3,
                Name = "Statistics",
                StartDate = new DateTime(2026, 4, 10),
                LecturerId = 3
            },
            new Course
            {
                Id = 4,
                Name = "C# Basics",
                StartDate = new DateTime(2026, 5, 1),
                LecturerId = 1
            }
        };

        public static List<Enrollment> Enrollments { get; } = new List<Enrollment>
        {
            new Enrollment
            {
                Id = 1,
                StudentId = 1,
                CourseId = 1,
                IsActive = true,
                FinalGrade = 4.5
            },
            new Enrollment
            {
                Id = 2,
                StudentId = 1,
                CourseId = 2,
                IsActive = true,
                FinalGrade = 5.0
            },
            new Enrollment
            {
                Id = 3,
                StudentId = 2,
                CourseId = 1,
                IsActive = true,
                FinalGrade = null
            },
            new Enrollment
            {
                Id = 4,
                StudentId = 3,
                CourseId = 3,
                IsActive = true,
                FinalGrade = 4.0
            },
            new Enrollment
            {
                Id = 5,
                StudentId = 4,
                CourseId = 2,
                IsActive = false,
                FinalGrade = 3.5
            },
            new Enrollment
            {
                Id = 6,
                StudentId = 5,
                CourseId = 4,
                IsActive = true,
                FinalGrade = null
            },
            new Enrollment
            {
                Id = 7,
                StudentId = 3,
                CourseId = 1,
                IsActive = true,
                FinalGrade = 4.8
            }
        };
    }