using System;
using System.Collections.Generic;

namespace _5._1Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application that prompts the user to create a list of exam grades and then calculates the average. Your application should include two loops:
            //Loop #1 should initialize the entry of all quiz grades.
            //Loop #2 should calculate the sum and average of the total quiz grades.


            List<double> ExamGrades = new List<double>();

            String Answer = " ";
            double Sum = 0;
            int count =0;
            do
            {
                Console.WriteLine("Please enter the your grade score out of a 100 possible points");
                ExamGrades.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("would you like to add another grade?");
                Answer = Console.ReadLine();


            } while (Answer.Equals("Yes", StringComparison.OrdinalIgnoreCase));


            for(int i = 0; i < ExamGrades.Count; i++)
            {
                Sum += ExamGrades[i];
                count++;
            }

            double Percen = (Sum / count)/100;
            Console.WriteLine($"the average percentage of your overall grade is {Percen:P} out of a 100%" );
            
            Console.ReadKey();
        }
    }
}
