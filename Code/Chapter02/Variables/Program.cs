using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall.");

           // int length1 = name.Length; // gives compile error
            int length2 = ((string)name).Length; // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} characters.");

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // this compiles but would throw and exception at run-time if you later store a data type that does not 
            // have have a property named length

            int length = anotherName.Length;

            // Local variables
            // Number without decimal inferred to be int, unless you add the L suffix which would make it Long
            // Number with decimal point inferred as double, unless it has M suffix (decimal) or F suffix (float)
            // Double quotes infer string, single quotes infer char
            var population = 66_000_000;
            var weight = 1.88; // in kg
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // string using double quotes
            var letter = 'Z'; // char using single quotes
            var happy = true; 

            // Default values
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
