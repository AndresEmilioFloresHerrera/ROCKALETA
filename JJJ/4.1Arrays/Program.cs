using System;
using System.Linq;

// Andres Emilio Flores Herrera ID: 113412581
// Problem number 4.1 (Array problem)

namespace _4._1Arrays
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String[] Fruits = { "apples", "oranges", "bananas", "grapes", "blueberries" };
            double[] Price = { 0.99, 0.50, 0.50, 2.99, 1.99 };
         
            bool Frutas;
            String item;
            do
            { 
            Console.WriteLine("Please enter the name of the item you want to know the price: ");
            item = Console.ReadLine();
            int intemindx = Array.IndexOf(Fruits, item);

                if (Fruits.Contains(item))
                {
                    Frutas = true;
                    Console.WriteLine($"the price of the item selected is: {Price[intemindx]:C2} per item");

                }
                else
                {
                    Frutas = false;
                    Console.WriteLine("you have either written an unexisting item or had a grammar mistake,");
                    Console.WriteLine(" ");
                }
            } while (Frutas == false);



            //Array.Exists(language, element => element == "Ruby")); 


            Console.ReadKey();
        }
    }
}




