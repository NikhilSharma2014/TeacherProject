// TeacherManager.cs in Class Library
using System;
using System.Collections.Generic;
using System.IO;

namespace TeacherRecords
{
    public class TeacherManager
    {
        private List<Teacher> teachers;

        public TeacherManager()
        {
            teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var teacher in teachers)
                {
                    sw.WriteLine($"{teacher.ID},{teacher.Name},{teacher.ClassSection}");
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                teachers.Clear(); // Clear existing data before loading new data
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            teachers.Add(new Teacher
                            {
                                ID = int.Parse(parts[0]),
                                Name = parts[1],
                                ClassSection = parts[2]
                            });
                        }
                    }
                }
            }
        }

        public void PrintTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.ID}, Name: {teacher.Name}, Class and Section: {teacher.ClassSection}");
            }
        }
    }
}
