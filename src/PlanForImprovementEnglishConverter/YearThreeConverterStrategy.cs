using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanForImprovementEnglishConverter
{
    public class YearThreeConverterStrategy : ITextConverterStrategy
    {
        public string Description => "";

        public string Blurb =>
            "Year 3 might well abolish \"y\" replasing it with \"i\" ";
        public string Convert(string input) => input.Replace("y", "i");
        
    }
}