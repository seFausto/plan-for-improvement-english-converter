using System;
using System.ComponentModel;

namespace PlanForImprovementEnglishConverter
{
    public class TextConverter
    {

        private ITextConverterStrategy _strategy;
        public TextConverter(ITextConverterStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Convert(string input)
        { 
            return _strategy.Convert(input);
        }
    }
}
