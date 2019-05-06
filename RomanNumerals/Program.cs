using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new RomanNumeralBuilder();
            builder.CalculateRomanNumerals(1674);
            Console.WriteLine(builder.RomanNumeralOutput);

            builder.CalculateRomanNumerals(1632);
            Console.WriteLine(builder.RomanNumeralOutput);
            Console.ReadKey();
        }
    }
}
