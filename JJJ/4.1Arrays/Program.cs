using System;
//using System.Collections.Generic;

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

                if (item == "apples" || item == "oranges" || item == "bananas" || item == "grapes" || item == "blueberries")
                {
                    Frutas = true;
                    Console.WriteLine($"the price of the item selected is: {Price[intemindx]:C2} per item");

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




//Create a console application that prompts the user to enter the item they desire, and return the value / 
//price of the item.Your console application should contain two parallel arrays, as well as an error if they enter or spell the item name incorrectly.

//Array #1: should contain items apples, oranges, bananas, grapes, blueberries
//Array #2: should contain prices for each item. Apples are 0.99, oranges are 0.50, bananas are 0.50, grapes are 2.99, blueberries are 1.99.

//using System;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = new int[10];
//        arr[0] = 100;
//        arr[1] = 200;
//        arr[2] = 300;
//        arr[3] = 400;
//        arr[4] = 500;
//        arr[5] = 600;
//        arr[6] = 700;
//        arr[7] = 800;
//        arr[8] = 900;
//        arr[9] = 1000;
//        int a = Array.IndexOf(arr, 800);
//        Console.WriteLine(a);