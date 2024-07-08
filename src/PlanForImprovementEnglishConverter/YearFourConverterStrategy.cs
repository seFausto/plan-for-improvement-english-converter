using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanForImprovementEnglishConverter
{
    public class YearFourConverterStrategy : ITextConverterStrategy
    {
        public string Description => "";

        public string Blurb =>
            "iear 4 might fiks the \"g/j\" anomali wonse and for all";
        public string Convert(string input) => input.Replace("g", "j");
        
    }
}