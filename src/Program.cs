using System;
using System.Collections.Generic;
using System.Linq;
namespace RayLDunbar.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();


            bool continueRunning = true;
            while (continueRunning)
            {
                DisplayMenu();
                int Input = Convert.ToInt32(Console.ReadLine());
                if (Input == 1) 
                {
                    Student.AddStudent(studentList);
                }
                else if ( Input == 2) 
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

    }
}
