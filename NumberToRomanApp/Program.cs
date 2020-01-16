using System;

namespace NumberToRomanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROMAN NUMERALS CODING CHALLENGE");
            
            var result = NumbertoRomanParser.NumberToRoman(500);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
