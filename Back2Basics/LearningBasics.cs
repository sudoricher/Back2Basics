using System;

namespace Back2Basics
{
    public static class LearningBasics
    {
        //Basics of writing outputs to the console...
        public static void Basics()
        {
            Console.WriteLine("Name: Bonginkosi");
            Console.WriteLine("Age: 25");
            Console.WriteLine("Favourite colour: Red");
        }

        //Basic console program that takes two numbers from a user, stores them and provides a sum of each..
        public static void Sum()
        {
            Console.Write("Please enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
        }

        //A program that explains single line and multiline comments
        public static void Comments()
        {
            Console.WriteLine("Single line comments, comment out a single line of code. We use // for single line comments");
            Console.WriteLine("Multiline comments, comment out a multiple lines of code. We use /* */ for mutliline comments");
        }
        //Declare variables of different types
        public static void DataTypes()
        {
            int num3 = 3;
            double frac = 1.23;
            float frac1 = 2.345f;
            string word = "Hello";
            bool real = false;
            char character = 'q';
            Console.WriteLine($"Different data types in c# int: {num3}, double:{frac}, float: {frac1}, string:{word}, boolean: {real}, char: {character}.");
        }

        //Ask the user for their first name and last name and print them in the format:
        public static void Introduction()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {lastName}");

            /*Store " The quick brown fox " in a variable and:
            Trim spaces
            Convert to uppercase
            Print result*/

            string wordTest = " The quick brown fox ";
            wordTest = wordTest.Replace(" ", "").ToUpper();
            Console.WriteLine(wordTest);

            Console.WriteLine(wordTest.Substring(8, 5));

            decimal number = 2;
            Console.WriteLine(13 / number);
        }


        public static void Calculations()
        {
            Console.Write("Please enter a number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter another number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Sum: {num1 + num2} ");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");
            Console.WriteLine($"Quotient: {num1 / num2}");
        }
        //Ask the user for an email and check if it contains "@" (print true or false).
        public static void EmailChecker()
        {
            Console.WriteLine("Please enter an email address: ");
            string emailAddress = Console.ReadLine();
            Console.WriteLine(emailAddress.Contains("@"));
        }
        public static void AreaCalculator()
        {
            Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.PI * Math.Pow(radius, 2));

        }
        public static void AbsoluteValue()
        {
            Console.WriteLine("Please enter any number.");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(Math.Abs(number), 2));
        }
    }
}
