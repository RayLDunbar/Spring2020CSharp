using System;
namespace RayLDunbar.CodeLou.ExerciseProject
{
    public class Student
    {
        
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public string LastClassCompleted { get; set; }
        public DateTimeOffset LastClassCompletedOn { get; set; }
        public static Student AddStudent()
        {
            Console.WriteLine("Enter Student Id");
            var studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            var studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            var studentLastName = Console.ReadLine();
            Console.WriteLine("Enter Class Name");
            var className = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed");
            var lastClass = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
            var lastCompletedOn = DateTimeOffset.Parse(Console.ReadLine());
            Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
            var startDate = DateTimeOffset.Parse(Console.ReadLine());

            var StudentRecord = new Student();

            StudentRecord.StudentId = studentId;
            StudentRecord.FirstName = studentFirstName;
            StudentRecord.LastName = studentLastName;
            StudentRecord.ClassName = className;
            StudentRecord.StartDate = startDate;
            StudentRecord.LastClassCompleted = lastClass;
            StudentRecord.LastClassCompletedOn = lastCompletedOn;
            Console.WriteLine($"Student Id | Name |  Class "); ;
            Console.WriteLine($"{StudentRecord.StudentId} | {StudentRecord.FirstName} {StudentRecord.LastName} | {StudentRecord.ClassName} ");
            return StudentRecord;
        }
    }
}