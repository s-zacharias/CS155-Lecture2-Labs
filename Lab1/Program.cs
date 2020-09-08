/// Lecture No. 2		Lab No. 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  September 7, 2020
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum of
/// these three numbers, and display the sum to the screen. 
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 5) Multiply the three integers together
/// 6) Print the product of the integers to the screen
/// 7) Divide the sum of the three numbers by the product of the three numbers
/// 8) Print the result to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, enter a second number and press enter, then enter the third number and press enter:");

            // declare three integer variables
            int n1, n2, n3, sum, product, result;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;

            // print a message along with the sum of the three numbers
            Console.WriteLine("The sum of those three numbers is:");
            Console.WriteLine(sum);

            // just to pause the screen.
            Console.ReadLine();

            // calculate the product of the three numbers
            product = n1 * n2 * n3;

            // print a message along with the sum of the three numbers
            Console.WriteLine("The product of those three numbers is:");
            Console.WriteLine(product);

            // just to pause the screen.
            Console.ReadLine();

            // calculate the result of dividing the sum of the three numbers by the product of the same three numbers
            result = sum / product;

            // print a message along with the sum of the three numbers
            Console.WriteLine("The result of dividing the sum of these three numbers by the product of the same three numbers is:");
            Console.WriteLine(result);


        }
    }
}
