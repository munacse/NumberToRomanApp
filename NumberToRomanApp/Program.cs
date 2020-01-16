using System;

namespace NumberToRomanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var result = NumbertoRomanParser.NumberToRoman(500);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
