﻿using System.Collections.Generic;
using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var Collection = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = new List<int>();
            var odds = new List<int>();

            foreach(var num in Collection)
            {
                if (num % 2 == 0)
                { 
                    evens.Add(num);
                    Console.WriteLine($"{num} is even");
                }
                else
                {
                    odds.Add(num);
                    Console.WriteLine($"{num} is odd");
                }
            }

           



            

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
