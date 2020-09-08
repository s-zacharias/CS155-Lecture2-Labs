/// Lecture No. 2		Lab No. 2
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  September 7, 2020
///
/// Problem Statement: Write a program that defines a variable initially assigned
/// to the number of coupons you win. Next, the program should output how many
/// candy bars and gumballs you can get if you spend all of your coupons on
/// candy bars first and any remaining coupons on gumballs.
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for the initial amount of coupons
/// 3) Calculate number of candy bars that can be gotten with that amount
/// 4) Calculate remaining amount of coupons
/// 5) Calculate number of gumballs that can be gotten with that amount
/// 6) Print the number of candy bars and gumballs to the screen
///
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
            Console.WriteLine("I will calculate the number of candy bars and gumballs you can get.");
            Console.WriteLine("Enter the number of coupons you have and press enter: ");

            // declare one integer variable
            int coupons, candyBars, remainingCoupons, gumballs;

            string userInput;
            userInput = Console.ReadLine();
            coupons = Int32.Parse(userInput);

            // calculate the number of candy bars
            candyBars = coupons / 10;

            // calculate the remaining number of coupons
            remainingCoupons = coupons % 10;

            // calculate the number of gumballs
            gumballs = remainingCoupons / 3;

            // print a message along with the number of candy bars
            Console.WriteLine("You can get this many candy bars:");
            Console.WriteLine(candyBars);

            // print a message along with the number of gumballs
            Console.WriteLine("You can get this many gumballs:");
            Console.WriteLine(gumballs);

            // just to pause the screen.
            Console.ReadLine();


        }
    }
}
