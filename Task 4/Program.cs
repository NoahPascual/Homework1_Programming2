// Noah Pascual
// MIS 3033-900
// Homework 1
// Task 3

//In this assignment, you will practice the following aspects of a Console App:
//•	Input, output
//•	Convert variable type
//•	Interpolated string
//•	If statement
//•	Conditional Logic operator 
//•	For loop, do-while loop
//•	method

// Create an application that will perform a couple of mathematical calculations. 
// 1. The first method that you will need to create is to calculate the y value of a line, given by the slope(m), the x value (x) and the y intercept (b).  
// Your method should be named LineValueForY with a return type of double.  Y.  Your method should accept 3 parameters, all of type double.  
// The first parameter will be the slope of the line (name this parameter m), the second parameter should be the x value (name this parameter x) and the last parameter should be the y intercept (name this parameter b).  
// The formula to calculate the Y value is Y = mx + b

// 2. The second method that you will need to create is to calculate the factorial of a number.  
// Your method name should be Factorial and should have a return type of int.  
// Your method should accept a single parameter of type int.  
// To calculate the factorial of a number, you multiply it by every number before it.e.g. 5 factorial = 5 * 4 * 3 * 2 * 1 = 120

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string title = "--- Task 4 ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Part One of Task 4 Variables
            double yInt;
            double xValue;
            double slopeM;

            // Asking user for variables to calculate Y value
            Console.WriteLine("Please enter the slope of the line (m): >>>");
            slopeM= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X Value (x): >>>");
            xValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y intercept (b): >>>");
            yInt = Convert.ToDouble(Console.ReadLine());

            // Return
            LineValueForY(yInt, xValue, slopeM);

            // Part Two of Task 4 Variables
            int factortialNum;

            // Asking user for a number to find it's factorial
            Console.WriteLine("\n\rPlease enter a number to find its facortial");
            factortialNum = Convert.ToInt32(Console.ReadLine());

            // Return
            ValueofFactorial(factortialNum);

            Console.ReadKey();

        }
        private static void LineValueForY(double yInt, double xValue, double slopeM)
        {
            // Formula to find Y value (Y=mx + b)
           Console.WriteLine($"\tYour Y value = {((slopeM * xValue) +yInt)}");
        }

        private static void ValueofFactorial(int factorialNum)
        {
            {
                // Formula thrpugh while loop to find the facorial of a number
                double result = 1;
                while (factorialNum != 1)
                {
                    result = result * factorialNum;
                    factorialNum = factorialNum - 1;
                }
                Console.WriteLine($"\tThe factorial of {factorialNum} = {result}");
            }
        }
    }
}
