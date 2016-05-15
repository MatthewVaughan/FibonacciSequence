using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FibonacciSequenceGH
{
    class Program
    {
        static void Main(string[] args)
        {

            //Display instructions for the user
            WriteLine("Please type in the limit and then push enter:");

            //Declare some variables
            int
                limit = int.Parse(ReadLine()),
                varA = 1,
                varB = 0,
                total = 0,
                prevTotal = 0,
                prevA = 1;

            //Display calculations taking place
            WriteLine("\n\n-----Squence Calculated-----\n");

            //Create a do while loop that will stop once the total has reached the set limit
            do
            {
                //Display the total at the beginning of every loop 
                WriteLine($"{total}");

                //prevTotal Gets the total
                prevTotal = total;

                //prevA gets the previous varA
                prevA = varA;

                //varA gets the previous total
                varA = prevTotal;

                //varB gets the prevA
                varB = prevA;

                //Add varA plus varB to get the new total
                total = varB + varA;

            } while (total <= limit);

            //Set a readline to allow the user time to view the sequence
            ReadLine();
        }
    }
}
