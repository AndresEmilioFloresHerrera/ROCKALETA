using System;

namespace Metodo3._2
{
    class Program
    {
        public static int Factorial(int choosenNumbero)
        {
            
            int multi= 1;
            for (int i = choosenNumbero; i > 0; i--)
            {

                multi  *= i ;
                
            }
            return multi;
        }
        static void Main(string[] args)
        {
            
            int ChoosenNumber;
            Console.WriteLine("please select a number in order to calculate its factorial: ");
            ChoosenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the factorial of {ChoosenNumber} is {Factorial(ChoosenNumber)}");


            Console.ReadKey();
        }
    }
}
//The second method that you will need to create is to calculate the factorial of a number.  Your method name should be Factorial and should have a return type of int.  
//Your method should accept a single parameter of type int.  To calculate the factorial of a number, you multiply it by every number before it.
//e.g. 5 factorial = 5 * 4 * 3 * 2 * 1 = 120
  