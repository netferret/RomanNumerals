using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumerals
{
    public class RomanNumeralBuilder : IDisposable
    {
        private string _romanNumeralOuput;
        public string RomanNumeralOutput
        {
            get {
                var output = _romanNumeralOuput;
                _romanNumeralOuput = string.Empty;
                return output;
            }
            set { _romanNumeralOuput = value; }
        }

        public void CalculateRomanNumerals(int integerInput)
        {
            foreach (var item in Enum.GetValues(typeof(RomanNumerals)).Cast<int>().Reverse())
            {
                integerInput = ProcessNumber(integerInput, item);
            }
        }

        private int ProcessNumber(int input, int number)
        {
            while (input >= number)
            {
                input -= number;
                RomanNumeralOutput += (RomanNumerals)number;
            }

            return input;
        }

        public void Dispose()
        {
            _romanNumeralOuput = null;
        }

        enum RomanNumerals : int
        {
            I = 1,
            IV = 4,
            V = 5,
            IX = 9,
            X = 10,
            L = 50,
            XC = 90,
            C = 100,
            CD = 400,
            D = 500,
            CM = 900,
            M = 1000
        }
    }
}
