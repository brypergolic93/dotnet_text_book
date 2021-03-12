using System;
using static System.Console;

namespace ChapterExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 2.1
            What type would you use to store the following numbers?
            Telephone number: string. Need to store leading zeroes. Ints are too possibly too small, floats and doubles risk data loss - shouldn't use floating point numbers here. Could use long but should be avoided
            Person's height: short, assuming it is in centimetres and no decimal precision is required. Stores -32768 to +32767
            Person's age: byte
            Person's salary: uint, positive integers taking up only 4 bytes in memory, can store up to 4.2 billion so we will miss out on some of the richest people
            A book's ISBN: long, must contain up to 13 digits
            A book's price: decimal - don't use floats or doubles because they cannot represent base 10 multiples well
            A book's shipping weight: double
            A country's population: uint
            Number of stars in the universe: double
            Number of employees in each of the small/medium businesses in the UK: ushort (assuming less than 50,000 people)       

            */

            WriteLine("--------------------------------------------------------------------------------------------");
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "Type", "Byte(s) of Memory", "Min", "Max");
            WriteLine("--------------------------------------------------------------------------------------------");
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "short", sizeof(short), short.MinValue, short.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "int", sizeof(int), int.MinValue, int.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "long", sizeof(long), long.MinValue, long.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "float", sizeof(float), float.MinValue, float.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "double", sizeof(double), double.MinValue, double.MaxValue);
            WriteLine(format: "{0,-8} {1,-20} {2,30} {3,30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);


        }
    }
}
