using System;

namespace Metodo3._2
{
    class Program
    {
        public int Factorial(int choosenNumber)
        {
            int finalResult;
            for (int i = choosenNumber; i >0; i--)
            {
                finalResult = choosenNumber ;
                finalResult = finalResult * i;
            }
            
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            int ChoosenNumber=0;
            Console.WriteLine($"the factorial of {ChoosenNumber} is {n.Factorial(ChoosenNumber)}");

        }
    }
}
//The second method that you will need to create is to calculate the factorial of a number.  Your method name should be Factorial and should have a return type of int.  
//Your method should accept a single parameter of type int.  To calculate the factorial of a number, you multiply it by every number before it.
//e.g. 5 factorial = 5 * 4 * 3 * 2 * 1 = 120
  