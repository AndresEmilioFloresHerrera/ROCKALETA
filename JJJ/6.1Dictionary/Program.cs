using System;
using System.Collections.Generic;
namespace _6._1Dictionary
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











            //String[] Fruits = { "apples", "oranges", "bananas", "grapes", "blueberries" };
            //double[] Price = { 0.99, 0.50, 0.50, 2.99, 1.99 };

            //bool Frutas;
            //String item;
            //do
            //{
            //    Console.WriteLine("Please enter the name of the item you want to know the price: ");
            //    item = Console.ReadLine();
            //    int intemindx = Array.IndexOf(Fruits, item);

            //    if (item == "apples" || item == "oranges" || item == "bananas" || item == "grapes" || item == "blueberries")
            //    {
            //        Frutas = true;
            //        Console.WriteLine($"the price of the item selected is: {Price[intemindx]:C2} per item");

            //    }
            //    else
            //    {
            //        Frutas = false;
            //        Console.WriteLine("you have either written an unexisting item or had a grammar mistake,");
            //    }
            //} while (Frutas == false);






            Console.ReadKey();

        }
    }
}
