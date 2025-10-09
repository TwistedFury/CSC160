using ScratchConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Weeks
{
    // You can make static classes in C#
    // This will make the IDE enforce that everything is marked as 'static'
    public static class Week01
    {
        #region Primitive Notes
        /*
         * Primitive Types
         * byte - 8-bit unsigned integer
         * short - 16-bit integer
         * int - 32-bit integer
         * long - 64-bit integer
         * 
         * float - 32-bit floating-point number ; 7 points of precision
         * double - 64-bit floating-point number; 15 points of precision
         * decimal - 128-bit floating point number; 31 points of precision
         * 
         * bool - 8-bit; smallest size of memory (1 byte)
         * 
         * char - 16-bit; C# uses UTF-16 encoding
         */
        #endregion

        // In C#, Methods are PascalCased
        // String = string (Syntactic Sugar)
        public static void Run()
        {
            DemoParsing();
        }

        public static void DemoParsing()
        {
            // Platonic C# (Redundancy is Java's favorite chromosome)
            string input = "42";
            int inputAsNum = int.Parse(input);

            int sexyInt;
            if (int.TryParse(input, out sexyInt)) Console.WriteLine($"Number is: {sexyInt}"); 
            else Console.WriteLine("Can't you number, idiot?");
        }

        public static void DemoInput()
        {
            // WHAT FAVORITE COLOR
            Console.Write("What's your favorite color?\t");
            string? input = Console.ReadLine();
            Console.WriteLine($"Fave Color: {(input ?? "null")}");
        }

        public static void DemoProperties()
        {
            // Create a Movie variable and instantiate it
            Movie movie = new Movie();
            movie.Title = "Krull";
            movie.Year = 1983;
            Console.WriteLine(movie);
        }

        public static void DemoDayOne()
        {
            #region Day One Code
            //sbyte signedByte = -1;
            //ushort unsignedShort = 1;
            //Console.WriteLine("Hello, World!");
            #endregion
        }
    }
}
