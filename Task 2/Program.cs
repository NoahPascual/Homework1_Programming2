// Noah Pascual
// MIS 3033-900
// Homework 1
// Task 2

//In this assignment, you will practice the following aspects of a Console App:
    //•	Input, output
    //•	Convert variable type
    //•	Interpolated string
    //•	If statement
    //•	Conditional Logic operator 
    //•	For loop, do-while loop
    //•	method

// Create an application that will keep prompting the user to input all 3 of their exam grades (using a For loop).  
// Calculate the average of their exam scores and output the result.  
// When you display the result, make sure to use a Format Specifier for percentages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string title = "--- Task 2 ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Set constant number of exams (3)
            const int numberOfExams = 3;
            int[] examGrade = new int[numberOfExams];

            // Ask user to input their 3 exam grades
            Console.WriteLine("Please enter your 3 most recent exam grades: >>>");
            for (int i = 0; i < numberOfExams; i++)
            {
                // While loop for redemption on users input
                while (!int.TryParse(Console.ReadLine(), out examGrade[i]))
                {
                    Console.WriteLine("You entered an incorrect value. Try again >>>");
                }

                // Output the users grade after every input
                Console.WriteLine($"\tExam Grade #{i + 1}: {examGrade[i]}");
            }

            // Call for average to output the average of the three exams.
            var average = examGrade.Average();
            Console.WriteLine($"\n\rYour average of the three exam grades is: {average/100:P2}");

            Console.ReadLine();
        }
    }
}
