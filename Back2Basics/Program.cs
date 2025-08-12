using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Back2Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basics of writing outputs to the console...
            Console.WriteLine("Name: Bonginkosi");
            Console.WriteLine("Age: 25");
            Console.WriteLine("Favourite colour: Red");

            //Basic console program that takes to numbers from a user, stores them and provides a sum of each..
            Console.Write("Please enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1 + num2));

            //A program that explains single line and multiline comments\
            Console.WriteLine("Single line comments, comment out a single line of code. We use // for single line comments");
            Console.WriteLine("Multiline comments, comment out a multiple lines of code. We use /* */ for mutliline comments");

            //Declare variables of different types
            int num3 = 3;
            double frac = 1.23;
            float frac1 = 2.345f;
            string word = "Hello";
            bool real = false;
            char character = 'q';

            Console.WriteLine($"Different data types in c# int: {num3}, double:{frac}, float: {frac1}, string:{word}, boolean: {real}, char: {character}.");

        }
    }
}
