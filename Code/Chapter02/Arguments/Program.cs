using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args) {
                WriteLine(arg);
            }
            */

            // Warn user if to enter correct arguments
            if (args.Length < 4)
            {
                WriteLine("You must specify two colours and dimensions, e.g.");
                WriteLine("dotnet run red yellow 80 40");
                return;
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), 
            value: args[0],
            ignoreCase: true);

            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor),
            value: args[1],
            ignoreCase: true);
        }
    }
}


/* CHAPTER EXERCISES
What type would you use to store the following numbers and why?
- Telephone number: 



*/