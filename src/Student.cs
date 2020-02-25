using System;
using System.Collections.Generic;
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
        public static void AddStudent(List<Student> studentList)
        {
            var StudentRecord = new Student();

            while (true) 
            {
                Console.WriteLine("Enter Student Id");
                var studentIdSuccessful = int.TryParse(Console.ReadLine(), out var studentId);
                if (studentIdSuccessful) 
                {
            StudentRecord.StudentId = studentId;
            break;}
            }
            Console.WriteLine("Enter First Name");
            var studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            var studentLastName = Console.ReadLine();
            Console.WriteLine("Enter Class Name");
            var className = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed");
            var lastClass = Console.ReadLine();
            while (true) {
                Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
                var lastCompletedOnSuccessful = DateTimeOffset.TryParse(Console.ReadLine(), out var lastClassCompletedOn);
                if (lastCompletedOnSuccessful) {
                    StudentRecord.LastClassCompletedOn = lastClassCompletedOn;
                    break;
                }
            } 
             while (true) {
                Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
                var startDateSuccessful = DateTimeOffset.TryParse(Console.ReadLine(), out var startDate);
                if (startDateSuccessful) {
                    StudentRecord.StartDate = startDate;
                    break;
                }
            } 

            StudentRecord.FirstName = studentFirstName;
            StudentRecord.LastName = studentLastName;
            StudentRecord.ClassName = className;
            StudentRecord.LastClassCompleted = lastClass;
            Console.WriteLine($"Student Id | Name |  Class "); ;
            Console.WriteLine($"{StudentRecord.StudentId} | {StudentRecord.FirstName} {StudentRecord.LastName} | {StudentRecord.ClassName} ");
            studentList.Add(StudentRecord);
        }
    }
}