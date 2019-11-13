using System;

namespace Delegates
{
    class Program
    {
        public static void PrintUpper(string str) 
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        static void Main(string[] args)
        {
            Strstruct sc = new Strstruct("string in struct");
            GetAString gAs = PrintUpper;
            gAs += PrintLower;
            gAs += sc.ConcatAndPrint;

            gAs("String in the beginning!!");
        }
    }
}
