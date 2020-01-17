using System;

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
                    Console.WriteLine("Please enter your first Grade: ");
                    Grade1 = Convert.ToDouble(Console.ReadLine());

                }
                else if (i == 1)
                {
                    Console.WriteLine("Please enter your second Grade: ");
                    Grade2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (i == 2)
                {
                    Console.WriteLine("Please enter your third Grade: ");
                    Grade3 = Convert.ToDouble(Console.ReadLine());
                }

            }

            Percentage = (Grade1 + Grade2 + Grade3) / 3;
            Console.WriteLine($"the percentage of your 3 grades is {Percentage}% out of a 100%");
            Console.ReadKey();
        }
    }
}
