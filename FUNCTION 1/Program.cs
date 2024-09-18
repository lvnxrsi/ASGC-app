using System;

namespace FUNCTION_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name:");
            string name = Console.ReadLine();
            double[] grades = Function1(); 
            double totalAverage = grades[3]; 
            string letterGrade = Function2(totalAverage);
            Function3(grades, letterGrade, name);
        }

        static double[] Function1()
        {
            Console.Write("Assignment Scores: ");
            double Assignment = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quiz Score: ");
            double Quiz = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Exam Score: ");
            double FinalExam = Convert.ToDouble(Console.ReadLine());

            double totalAverage = (Assignment * 0.25) + (Quiz * 0.35) + (FinalExam * 0.40);

            double[] weightedaverage = { Assignment, Quiz, FinalExam, totalAverage };
            return weightedaverage;  
        }



        static void Function3(double[] grades, string letterGrade, string name)
        {
            Console.WriteLine("\nStudent Report");
            Console.WriteLine($"=============================");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Assignment Score: {grades[0]}");
            Console.WriteLine($"Quiz Score: {grades[1]}");
            Console.WriteLine($"Final Exam Score: {grades[2]}");
            Console.WriteLine($"Weighted Average: {grades[3]:F2}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
    }
}
