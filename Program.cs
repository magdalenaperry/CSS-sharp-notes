// imports dictionaries to use, also needed for lists
using System.Collections.Generic;

// common namespace called "System"'
// using is similar to require or import
// The System namespace is part of the .NET framework. It is a collection of commonly used methods, data types, and data structures, which are the essential building blocks of a C# application.
using System;

// Namespaces are used to organize and provide a level of separation in the code—something like modules in Node.js.
namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Main() is a very special method that serves as the entry point of the application. Can only be one entry point
        // The Main() method is invoked when the program runs—and it's where we'll place the code.
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string greeting = "Hello";
            greeting = greeting + " World";
            Console.WriteLine("greeting" + greeting);
            Console.WriteLine($"greeting {greeting}"); 
            Console.WriteLine("greeting: {0}", greeting);

            // How do you find the area of a square? Area = side * side
            double side = 3.14;
            double area = side * side;
            Console.WriteLine("area: {0}, {1}", area, area.GetType());

            Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
            Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
            Console.WriteLine(1 + 2 * 3);     // order of operations
            Console.WriteLine(10 / 3.0);      // int's and doubles
            Console.WriteLine(10 / 3);        // int's 
            Console.WriteLine("12" + "3");    // string interpolate

            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink

                    string stringNum = "2";
            int intNum = Convert.ToInt16(stringNum);
            Console.WriteLine(intNum);

            // Int16 designates the storage available for the variable. This calculates to 16 bits, which is 2^16 or 65,536 values, which is normally enough for daily computation. There are also Int32 and Int64 for larger calculations when necessary.
            Console.WriteLine(intNum.GetType()); // output: System.Int32

            // method 1 for initializing dictionary after importing system collections generic
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
            myScoreBoard.Add("firstInning", 10);
            myScoreBoard.Add("secondInning", 20);
            myScoreBoard.Add("thirdInning", 30);

            // method 2 for init dictionary
            Dictionary<string, int> yourScoreBoard = new Dictionary<string, int>(){
                { "firstInning", 30},
                { "secondInning", 40},
                
            };

            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);

// Arrays
            // arrays must be declared with datatype and size
            string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);
            Console.WriteLine(favFoods[0]);


// Lists
            //
            List<string> employees = new List<string>() { "adam", "amy" };
            employees.Add("barbara");
            employees.Add("billy");

            Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
    

// Loops

            //
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}",  i);
            }

// 866-258-0114

            int i = 0;
            // initializer, condition and interator sections are optional
            for( ; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }
                
            // decimals 
            for (double d = 1.01D; d < 1.10; d+= 0.01D) {
                Console.WriteLine("Value of i: {0}", d);
            }
    
    
        }
    }
}


// Common C# conventions are to use a company name for the root namespace in order to ensure that it is unique.