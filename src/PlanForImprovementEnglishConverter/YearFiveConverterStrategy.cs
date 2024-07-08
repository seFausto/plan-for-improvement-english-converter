using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanForImprovementEnglishConverter
{
    public class YearFiveConverterStrategy : ITextConverterStrategy
    {
        public string Description => "";

        public string Blurb =>
            "Jenerally, then, the improvement would kontinue iear bai iear with iear 5 " +
            "doing awai with useless double konsonants";

        public string Convert(string input)
        {
            return RemoveDuplicateConsonants(input);
        }

        private static string RemoveDuplicateConsonants(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var result = new StringBuilder();
            var previousChar = '\0';

            foreach (var currentChar in input.Where(currentChar => 
                         !IsConsonant(currentChar) || currentChar != previousChar))
            {
                result.Append(currentChar);
                previousChar = currentChar;
            }

            return result.ToString();
        }
        private static bool IsConsonant(char c)
        {
            var lowerChar = char.ToLower(c);
            return lowerChar >= 'a' && lowerChar <= 'z' && !"aeiou".Contains(lowerChar);
        }
    }
}