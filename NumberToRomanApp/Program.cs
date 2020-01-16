using System;

namespace NumberToRomanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to Roman parser!");
            
            var result = NumbertoRomanParser.NumberToRoman(500);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
