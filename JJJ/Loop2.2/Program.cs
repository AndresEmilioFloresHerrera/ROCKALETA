﻿using System;

namespace Loop2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //                Create an application that asks the user for their exam score, add their input to an accumulator and then ask 
            //                the user if they have another score to enter.If they do, ask for the exam score and repeat the process until
            //                they say no.Make sure that their answer is case insensitive(e.g.they can say Yes or yes and your code treats it the same).
            //                Once they say no, calculate the average of all of the exam scores based upon your accumulator and your counting variable.
            //                Make sure that you use some sort of a While Loop, an accumulating variable(to keep track of the total exam scores), 
            //                and a counting variable(to keep track of the number of scores they entered).


            String Answer="yes";
            Double Grade = 0;
            int counter = 0;
            double Sum = 0;
            do //while (Answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                
                Console.WriteLine("Please enter your exam score:");
                Grade = Convert.ToDouble(Console.ReadLine());
                Sum += Grade;

                counter ++;
                Console.WriteLine("would you like to continue: ");
                Answer = Console.ReadLine();


            } while (Answer.Equals("Yes", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(Grade);
            Console.WriteLine(counter);

            Console.ReadKey();



            //if (MyString.Equals(YourString, StringComparison.OrdinalIgnoreCase))






            //static double Add(double[] numbersToAddUp)
            //{
            //    double r = 0;
            //    int counter = 0;
            //    while (counter < numbersToAddUp.Length)
            //    {
            //        var number = numbersToAddUp[counter];
            //        r += number;
            //        counter++;
            //    }
        }
    }
}