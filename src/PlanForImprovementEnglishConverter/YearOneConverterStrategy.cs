using System.Text;

namespace PlanForImprovementEnglishConverter
{
    public class YearOneConverterStrategy : ITextConverterStrategy
    {
        private const string _vowels = "aeiouAEIOU";
        public string Convert(string input)
        {
            var result = ReplaceCwithS(input);
            result = ReplaceCwithK(result);
            
            return ReplaceXwithKs(result);
        }

        private static string ReplaceXwithKs(string input)
        {
            return input.Replace("x", "ks");
        }

        private string ReplaceCwithK(string input)
        {
            return input.Replace("ce", "se")
                .Replace("ci", "si")
                .Replace("cy", "sy");
        }

        private static string ReplaceCwithS(string input)
        {
            var result = input.Replace("ca", "ka")
                .Replace("co", "ko")
                .Replace("cu", "ku")
                .Replace("c ", "k ")
                .Replace("c.", "k.")
                .Replace($"c\n", "k\n");

            StringBuilder sb = new StringBuilder(result);

            for (int index = 0; index < sb.Length; index++)
            {
                if (index+1 < sb.Length && sb[index] == 'c' 
                    && (IsConsonant(sb[index+1]) && sb[index + 1] != 'h'))
                {
                    sb[index] = 'k';
                }
            }

            return result;
                
        }

        private static bool IsConsonant(char v)
        {
            return _vowels.IndexOf(v) >= 0;
        }

        public string Blurb => "For example, in Year 1 that useless letter \"c\" would be dropped to be replased either by \"k\" or \"s\", and likewise \"x\" would no longer be part of the alphabet.";

        public string Description => "Replace \"C\" with \"K\" or \"S\" and \"X\" with \"KS\"";
    }
}
