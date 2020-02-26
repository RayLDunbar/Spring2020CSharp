using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace RayLDunbar.CodeLou.ExerciseProject
{
    class Program
    {
        static string _studentRepositoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\students.json";
        static List<Student> studentList = File.Exists(_studentRepositoryPath) ? Read() : new List<Student>();

        public static void Save()
        {
            using (var file = File.CreateText(_studentRepositoryPath))
            {
                file.WriteAsync(JsonSerializer.Serialize(studentList));
            }
        }

        static List<Student> Read()
        {
            return JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(_studentRepositoryPath));
        }

        static void Main(string[] args)
        {
            //List<Student> studentList = new List<Student>();


            bool continueRunning = true;
            while (continueRunning)
            {
                DisplayMenu();
                int Input = Convert.ToInt32(Console.ReadLine());
                if (Input == 1)
                {
                    Student.AddStudent(studentList);
                }
                else if (Input == 2)
                {
                    DisplayStudentList(studentList);
                }
                else if (Input == 3)
                {
                    FindStudent(studentList);
                }
                else
                {
                    continueRunning = false;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. New Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Find Student By Name");
            Console.WriteLine("4. Exit");

        }

        static void DisplayStudentList(List<Student> studentList)
        {
            foreach (Student StudentRecord in studentList)
            {
                Console.WriteLine($"{StudentRecord.FirstName} {StudentRecord.LastName} {StudentRecord.StudentId}");
            }

        }

        static void FindStudent(List<Student> studentList)
        {
            Console.WriteLine("Enter student last name");
            var SearchStudent = Console.ReadLine();
            var students = studentList.Where(f => f.LastName.Contains(SearchStudent)).ToList();
            DisplayStudentList(students);

        }

         /* private static void Save()
        {
            JsonSerializer.Serialize(studentList);
            File.CreateText(_studentRepositoryPath).Write(serializedStudentList);
            throw new NotImplementedException();
        }*/

    }
}
