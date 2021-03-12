using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");

            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
        }
    }
}
