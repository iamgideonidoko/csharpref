// String Interpolation is a feature that enables the easy insertion of data
// and expression values into a string variable
using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // Output information using formatting
            Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}",
                year, make, model, miles, price);

            // Using string interpolation
            Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles} miles and costs {price:C2}");

            // With inline expressions
            Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles *1.6:F2} kilometers and costs {price:C2}");

            int a = 100;
            float b = 250.0f;
            string c = "CSharp";

            // String output the old way - using placeholders
            Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

            // Using string interpolation, the code is much easier to read
            Console.WriteLine($"The values are {a}, {b} and {c}");

            // Interpolated strings can contain expressions as well
            Console.WriteLine($"(a + b)/b is {(a + b)/b}");
            Console.WriteLine($"{c} in upper-case is {c.ToUpper()}");

            // Complex objects can be embedded in strings this way as well
            DateTime now = DateTime.Now;
            Console.WriteLine($"Today is {now}");

        }
    }
}
