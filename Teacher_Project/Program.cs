// Program.cs in Console App
using System;
using TeacherRecords;

namespace TeacherRecordsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherManager teacherManager = new TeacherManager();

            // Example data
            teacherManager.AddTeacher(new Teacher { ID = 1, Name = "Anish", ClassSection = "Math-A" });
            teacherManager.AddTeacher(new Teacher { ID = 2, Name = "Amit", ClassSection = "English-B" });

            // Save to file
            teacherManager.SaveToFile("MasterRecords.txt");

            // Load from file
            teacherManager.LoadFromFile("MasterRecords.txt");

            // Print teachers
            teacherManager.PrintTeachers();

            Console.ReadLine();
        }
    }
}
