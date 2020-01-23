using System;
//using System.Collections.Generic;

namespace _4._1Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Fruits = new string[5];
            Fruits[0] = "apples";
            Fruits[1] = "oranges";
            Fruits[2] = "bananas";
            Fruits[3] = "grapes";
            Fruits[4] = "blueberries";
            double[] Price = new double[5];
            Price[0] = 0.99;
            Price[1] = 0.50;
            Price[2] = 0.50;
            Price[3] = 2.99;
            Price[4] = 1.99;


            String item;
            Console.WriteLine("Please enter the name of the item you want to know the price: ");
            item = Console.ReadLine();

            int intemindx = Array.IndexOf(Fruits, item);




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