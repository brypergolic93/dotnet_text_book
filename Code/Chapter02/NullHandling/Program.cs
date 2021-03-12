using System;
#nullable enable

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int thisCannotBeNull = 4;
            //thisCannotBeNull = null;

            //int? thisCouldBeNull = null;
            //Console.WriteLine(thisCouldBeNull);
            //Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            //thisCouldBeNull = 7;
            //Console.WriteLine(thisCouldBeNull);
            //Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = "Reumannplatz";
            address.City = "London";
            address.Region = "Wien";

            string? authorName = null;

            // the following throws a null reference exception
            // int x = authorName.Length;
            // fix with the question mark after int and authorName
            int? y = authorName?.Length;

            // result will be 3 if authorName?.length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);
        }
    }
}
