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
            const double tax = .089;

           


            Console.WriteLine("Please enter the number of Cogs you would like tu purchase: ");
            int numberOfCogs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of Gears you would like to purchase: ");
            int numberOfGears = Convert.ToInt32(Console.ReadLine());

            int TotalNumberOfItems = numberOfCogs + numberOfGears;
            double TotalCostbeforeMarkup, totalcost, DiscountAmount, SalesTax, GrandTotal;

            TotalCostbeforeMarkup = (numberOfCogs * SPriceCogs) + (numberOfGears * SPriceGears);

            if (TotalNumberOfItems >= 16 || numberOfGears >=10 || numberOfCogs >= 10)
            {
                totalcost = TotalCostbeforeMarkup * (1+DiscountdMarkUp);
            }
            else
            {
                totalcost = TotalCostbeforeMarkup * (1+MarkUp);

            }

            if (TotalNumberOfItems >= 16 || numberOfGears >= 10 || numberOfCogs >= 10)
            {
                DiscountAmount = TotalCostbeforeMarkup * 0.025;
            }
            else
            {
                DiscountAmount = 0;

            }

            SalesTax = totalcost * tax;

            GrandTotal = totalcost + SalesTax;

            Console.WriteLine($"The total cost for the products before taxes is : {totalcost:C}");
            Console.WriteLine($"A total amount of {DiscountAmount:C} in discount  has been applied due to the number of products purchased");
            Console.WriteLine($"the total amount of taxes applied is: {SalesTax:C}");
            Console.WriteLine($"the grand total of this sell is: {GrandTotal:C}");
            Console.WriteLine(" ");
            Console.WriteLine("THANK YOU FOR YOUR BUSINESS");



            Console.ReadKey();



        }  
}
}
