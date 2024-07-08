using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanForImprovementEnglishConverter
{
    public class YearTwoConverterStrategy : ITextConverterStrategy
    {
        public string Description => "";

        public string Blurb =>
            "Year 2 might reform \"w\" spelling, so that \"which\" and \"one\" would take the same konsonant";

        private readonly HashSet<string> _skipWords =
        [
            "who",
            "whom",
            "whose",
            "whole",
            "wholly",
            "whoever",
            "whosever"
        ];

        private readonly Dictionary<string, string> _replaceWSound = new Dictionary<string, string>
        {
            { "one", "won" }
        };
        public string Convert(string input)
        {
            var sb = new StringBuilder();

            foreach (var word in input.Split(' '))
            {
                var lowerCase = word.ToLower();

                if (_replaceWSound.TryGetValue(lowerCase, out var value))
                {
                    lowerCase = value;
                }
                else if (lowerCase.StartsWith("wh") 
                    && !_skipWords.Contains(lowerCase))
                {
                    lowerCase = lowerCase.Replace("wh", "w");
                }
                
                sb.Append(lowerCase);
            }

            return sb.ToString();
        }
    }
}