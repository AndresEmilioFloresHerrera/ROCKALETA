using System;
using System.Collections.Generic;

// Andres Emilio Flores Herrera ID: 113412581
// Problem number 5.1 (List problem)

namespace _5._1Lists
{
    class Program
    {
        static void Main(string[] args)
        {
           


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
