using System;

namespace Ifff
{
    class Program
    {

        static void Main(string[] args)
        {
            const double SPriceCogs = 79.99;
            const double SPriceGears = 250;
            const double MarkUp = .15;
            const double DiscountdMarkUp = .125;
            const double tax = .89;

            //   You will be creating an application to help our sales associates sell our main products, cogs and gears.Cogs have a whole sale price
            //    of $79.99 and gears have a whole sale price of $250.00.When our sales associates are selling to our customers on the floor, we have a standard 
            //    15 % markup on our wholesale price for our sales price.However, if the customer purchases more than 10 of either item or a combined quantity of 16
            //    items we only markup the items by 12.5 %.On top of this, the sales tax for all sales is 8.9 %.
            //   Create a console application that will prompt the sales associate for the number of cogs as well as the number of gears for a sales order.Create class level
            //   constant variables for the whole sale prices for the items as well as the markup percentages.Once the user has input all of the data, create a receipt and display the 
            //    total cost for the items, the discount amount, the sales tax amount as well as the grand total.Format all values appropriately(e.g.percentages should have the appropriate
            //    format specifier, same with currency) as well as make the receipt user friendly(e.g. do not just list all the values next to each other, put on different lines and make
            //        sure to show what each value represents).


            Console.WriteLine("Please enter the number of Cogs you would like tu purchase: ");
            int numberOfCogs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of Gears you would like to purchase: ");
            int numberOfGears = Convert.ToInt32(Console.ReadLine());
            int TotalNumberOfItems = numberOfCogs + numberOfGears;
            double TotalCost, DiscountAmount, SalesTax, GrandTotal;

            if (TotalNumberOfItems >= 16 || numberOfGears >=10 || numberOfCogs >= 10)
            {
                TotalCost = ((numberOfGears * SPriceGears) * (1 + DiscountdMarkUp)) + ((numberOfCogs * SPriceCogs) * (1 + DiscountdMarkUp));
            }
            else
            {
                TotalCost = ((numberOfGears * SPriceGears) * (1 + MarkUp))+ ((numberOfCogs * SPriceCogs) * (1 + MarkUp));

            }

            

            Console.ReadKey();



        }  
}
}
