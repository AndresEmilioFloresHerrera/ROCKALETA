using System;
using System.Collections.Generic;
namespace _6._1Dictionary
// Andres Emilio Flores Herrera ID: 113412581
// Problem number 6.1 (dictionary problem)
{
    class Program
    {
        static void Main(string[] args)
        {
            //Redo the Arrays problem, however this time use a dictionary.  Your key value will be the fruit name and the value will be the price of the piece of fruit.

            Dictionary<String, double> dict = new Dictionary<String, double>();

            dict.Add("apples", 0.99);
            dict.Add("oranges", 0.50);
            dict.Add("bananas", 0.50);
            dict.Add("grapes", 2.99);
            dict.Add("blueberries", 1.99);

            bool Frutas;
            do
            {
                Console.WriteLine("Please enter the name of the item you want to know the price: ");
                String item = Console.ReadLine();
                if (dict.ContainsKey(item))
                {

                    Frutas = true;
                    Console.WriteLine($"the price of the item selected is {dict[item]:C2}");
                }
                else
                {
                    Frutas = false;
                    Console.WriteLine("you have either written an unexisting item or had a grammar mistake,");
                }
            } while (Frutas == false);









            Console.ReadKey();

        }
    }
}
