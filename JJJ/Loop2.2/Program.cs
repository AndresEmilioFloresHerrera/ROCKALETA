using System;

namespace Loop2._2
{
    class Program
    {
        static void Main(string[] args)
        {
           


            String Answer=" ";
            double Grade = 0;
            int counter = 0;
            double Sum = 0;
            do 
            {
                
                Console.WriteLine("Please enter your exam score out of a 100 possible points:");
                Grade = Convert.ToDouble(Console.ReadLine());
                Sum += Grade;

                counter ++;
                Console.WriteLine("would you like to continue: ");
                Answer = Console.ReadLine();


            } while (Answer.Equals("Yes", StringComparison.OrdinalIgnoreCase));

            double Average;
            Average = (Sum / counter)/100;

            Console.WriteLine($"your average exam grade is: {Average:P} out a 100%");

            Console.ReadKey();
             
        }
    }
}
