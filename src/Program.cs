using System;
namespace RayLDunbar.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueRunning = "Y";
            while (continueRunning == "Y")
            {
                Student.AddStudent();
                Console.WriteLine("Do you want to enter another student?");
                continueRunning = Console.ReadLine().ToUpper();
            }
        }

    }
}
