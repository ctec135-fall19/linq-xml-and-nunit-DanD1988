/*
Author: Daniel Davidson
Date: 11/3/2019
CTEC 135: Microsoft Software Development with C#
    Module 6, Programming Assignment 5, Problem 3
    
    * Create a new solution for this assignment

      Instructions: Unit Testing Assignment

    * Repeat this assignment on your own machine. 
    * BONUS: create your own class and methods and 
      associated test library and tests.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyMathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** MyMath Console ******");
            // Exception handler for MyMath1
            try
            {
                Console.WriteLine("101 + 99 = {0}", MyMath1.Add((byte)101, (byte)99));
                Console.WriteLine("101 + 201 = {0}", MyMath1.Add(101, 201));

              
            }
            catch (Exception)
            {
                Console.WriteLine("Value is exceeded.");
            }

            // Exception handler for MyMath2
            try
            {
                Console.WriteLine("101 + 99 = {0}", MyMath2.Add((byte)101, (byte)99));
                Console.WriteLine("101 + 201 = {0}", MyMath2.Add(101, 201));

            }
            catch (Exception)
            {
                Console.WriteLine("Value is exceeded.");
            }




        }
    }
}
