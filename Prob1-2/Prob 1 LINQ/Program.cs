/*
Author: Daniel Davidson
Date: 11/2/2019
CTEC 135: Microsoft Software Development with C#

    Module 6, Programming Assignment 5, Problem 1

     LINQ
    * Create a static method that
      creates an array of strings (the ordering of the 
      strings should be random)
    * Create a LINQ statement that returns the strings
      that start with 'a' - 'f'
      output the result 
    * modify the array in such a way that the result
      will be different output the result again
    * modify the array in such a way that the result 
      will be different
    * capture the result as a List<string> object and return it
      in Main, output the returned result
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling static method
            QueryStringArray();
         
        }

        // Static method that creates a array of strings
        static void QueryStringArray()
        {
            // Random ordered array
            string[] books = {"Fahrenheit 451", "Dune", "Clockwork Orange", 
                "Eiger Dreams", "Blazed", "American Sniper", "War and Peace", 
                "IT", "On the Road", "Return of the King" };

            // Query for printing out string a-f 
            var bookOrder = from book in books
                            where book[0] >= 'A' && book[0] <= 'F'
                            /*
                            where book.StartsWith("A")
                            || book.StartsWith("B")
                            || book.StartsWith("C")
                            || book.StartsWith("D")
                            || book.StartsWith("E")
                            || book.StartsWith("F")
                            */
                            orderby book ascending
                            select book;

            Console.WriteLine("Books in Library: A - F\n");
            // loops through array
            foreach (var i in bookOrder)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine();

            // Modified version
            var bookOrder2 = from book in books
                             where book.Contains(" ")
                             orderby book descending
                             select book;
            Console.WriteLine("Modified the array:\n");
            foreach (var i in bookOrder2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Modified version
            var bookOrder3 = from book in books
                             where book.Contains("the")
                             select book;

            Console.WriteLine("Modified the array:\n");
            
            foreach (var i in bookOrder3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("List<string> object");
            // Capturing result as list string object
            List<string> bookOrder4 = (from book in books
                                       where book.Contains(" ")
                                       orderby book
                                       select book).ToList<string>();
            
            foreach (var i in bookOrder4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }

    }

        
}

