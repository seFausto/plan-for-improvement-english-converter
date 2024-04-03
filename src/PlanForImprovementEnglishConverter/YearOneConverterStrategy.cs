using System.Text;

namespace PlanForImprovementEnglishConverter
{
    public class YearOneConverterStrategy : ITextConverterStrategy
    {
        const string _blurb = "For example, in Year 1 that useless letter \"c\" would be dropped to be replased either by \"k\" or \"s\", and likewise \"x\" would no longer be part of the alphabet.";
        const string _description = "Replace \"C\" with \"K\" or \"S\" and \"X\" with \"KS\"";

        const string _vowels = "aeiouAEIOU";
        public string Convert(string input)
        {
            var result = ReplaceCwithS(input);
            result = ReplaceCwithK(result);
            
            return ReplaceXwithKs(result); ;
        }

        private string ReplaceXwithKs(string input)
        {
            return input.Replace("x", "ks");
        }

        private string ReplaceCwithK(string input)
        {
            return input.Replace("ce", "se")
                .Replace("ci", "si")
                .Replace("cy", "sy");
        }

        private string ReplaceCwithS(string input)
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

        private bool IsConsonant(char v)
        {
            return _vowels.IndexOf(v) >= 0;
        }

        public string Blurb { 
            get
            {
                return _blurb;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }
    }
}
