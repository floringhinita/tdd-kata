using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        private readonly Dictionary<int, string> dict = 
            new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

        public string Convert(int number)
        {
            var result = new StringBuilder();

            foreach (var entry in dict)
            {
                while (number >= entry.Key)
                {
                    result.Append(entry.Value);
                    number -= entry.Key;
                }
            }

            return result.ToString();
        }
    }
}
