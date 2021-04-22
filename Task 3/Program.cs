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

// Create an application that asks the user for their exam score, add their input to an accumulator and then ask the user if they have another score to enter.  
// If they do, ask for the exam score and repeat the process until they say no.  
// Make sure that their answer is case insensitive (e.g. they can say Yes or yes and your code treats it the same). 
// Once they say no, calculate the average of all of the exam scores based upon your accumulator and your counting variable.
// Make sure that you use some sort of Loop, an accumulating variable (to keep track of the total exam scores), and a counting variable (to keep track of the number of scores they entered).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Task 3---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Variables
            string exam, isAnother;
            int examSum, count = 1;

            // Ask user to insert their grades
            Console.WriteLine("\tPlease insert your exam grade: >>>");
            exam = Console.ReadLine();
            examSum = Convert.ToInt32(exam);

            // Ask if they'd like to add more
            Console.Write("Would you like to add more exam grades (I.e. \"Yes\" or \"No\" >>> ");
            isAnother = Console.ReadLine();
            while (isAnother.ToLower() == "yes")
            {
                Console.Write("\tEnter your exam grade: >>> ");
                exam = Console.ReadLine();

                // Increment the values 
                count++;

                examSum = examSum + Convert.ToInt32(exam);

                Console.Write("Would you like to add more exam grades (I.e. \"Yes\" or \"No\" >>> ");
                isAnother = Console.ReadLine();
            }

            // Average variable with output
            double avg = examSum / count;
            Console.WriteLine("\nYour average exam grade is  {0}. ", avg);

            Console.ReadKey();
        }
    }
}
