using System;
// Andres Emilio Flores Herrera ID: 113412581
// Problem number 2.1 (Loop problem)

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Grade1 = 0, Grade2 = 0, Grade3 = 0, Percentage;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Please enter your first score out of a 100 points : ");
                    Grade1 = Convert.ToDouble(Console.ReadLine());

                }
                else if (i == 1)
                {
                    Console.WriteLine("Please enter your second score out of a 100 points: ");
                    Grade2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (i == 2)
                {
                    Console.WriteLine("Please enter your third score out of a 100 points: ");
                    Grade3 = Convert.ToDouble(Console.ReadLine());
                }

            }

            Percentage = ((Grade1 + Grade2 + Grade3) /100 )/3;
            Console.WriteLine($"the percentage of your 3 grades is {Percentage:P} out of a 100%");
            Console.ReadKey();
        }
    }
}
