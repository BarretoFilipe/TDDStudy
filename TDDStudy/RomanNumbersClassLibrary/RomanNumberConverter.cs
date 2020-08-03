using System.Collections.Generic;

namespace RomanNumbersClassLibrary
{
    public class RomanNumberConverter
    {
        private static Dictionary<char, int> romanNumberTable = new Dictionary<char, int>()
        {
            { 'I', 1},
            { 'V', 5},
            { 'X', 10},
            { 'L', 50},
            { 'C', 100},
            { 'D', 500},
            { 'M', 1000}
        };

        public int Convert(string romanNumber)
        {
            var total = 0;
            var lastNumberOnRight = 0;
            for (int i = romanNumber.Length -1; i >= 0; i--)
            {
                var currentNumber = romanNumberTable[romanNumber[i]];
                var multiplier = 1;

                if (currentNumber < lastNumberOnRight)
                    multiplier = -1;

                total += currentNumber * multiplier;

                lastNumberOnRight = currentNumber;
            }
            return total;
        }
    }
}