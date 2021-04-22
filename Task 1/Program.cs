// Noah Pascual
// MIS 3033-900
// Homework 1
// Task 1

//In this assignment, you will practice the following aspects of a Console App:
//•	Input, output
//•	Convert variable type
//•	Interpolated string
//•	If statement
//•	Conditional Logic operator 
//•	For loop, do-while loop
//•	method

//Task 1:
// You will be creating a console application to help our sales associates sell our main products, cogs and gears.  Cogs have a whole sale price of $79.99 and gears have a whole sale price of $250.00.  
// When our sales associates are selling to our customers on the floor, we have a standard 15% markup on our wholesale price for our sales price.  
// However, if the customer purchases more than 10 of either item or a combined quantity of 16 items we only markup the items by 12.5%.  
// On top of this, the sales tax for all sales is 8.9%.
//•	Create a console application that will prompt the sales associate for the number of cogs as well as the number of gears for a sales order.  
//•	Create class level constant variables for the whole sale prices for the items as well as the markup percentages.  
//•	Once the user has input all of the data, create a receipt and display the total cost for the items, the discount amount, the sales tax amount as well as the grand total.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program 
    {

        // Constant Variables (Prices, Markup, SalesTax)
        const double cogprice = 79.99;
        const double gearprice = 250.00;
        const double markup1 = 1.15;
        const double markup2 = 1.125;
        const double salestax = 0.089;

        static void Main(string[] args)
        {

            string title = "--- Task 1 ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Main Method Variables
            double totalPrice;
            double discountPrice; 
            double discount;
            double salesTaxPrice;

            // User Input
            Console.WriteLine("Please enter the number of cogs >>>");
            int cogs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of gears >>>");
            int gears = Convert.ToInt32(Console.ReadLine());

            // Standard Total with 15% Markup
            totalPrice = (cogs * cogprice + gears * gearprice) * markup1;

            
            // "However, if the customer purchases more than 10 of either item or a combined quantity of 16 items we only markup the items by 12.5%."  
            if (cogs + gears >= 16 || cogs > 10 || gears > 10)
            {
                discountPrice = (cogs * cogprice + gears * gearprice) * markup2;
            }
            else
            {
                discountPrice = (cogs * cogprice + gears * gearprice) * markup1;
            }

            // Calculate Discount (If the customer has purchases >10 of both items, or a total of 16 together, that number will be subtracted from the totalPrice of the original 15% markup value).
            discount = totalPrice - discountPrice;

            // Calculate Sales Tax Price
            salesTaxPrice = (totalPrice - discount) * salestax;

            // Console Output (Receipt)
            Console.WriteLine($"\t Total cost:      {totalPrice:C2}");
            Console.WriteLine($"\t Discount:        {discount:C2}");
            Console.WriteLine($"\t Sales tax:       {salesTaxPrice:C2}");
            Console.WriteLine($"\t Grand Total:     {totalPrice - discount + salesTaxPrice:C2}"); 
            Console.ReadKey();
        }
    }
}
