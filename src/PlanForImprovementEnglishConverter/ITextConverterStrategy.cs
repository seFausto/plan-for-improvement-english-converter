namespace PlanForImprovementEnglishConverter
{
    public interface ITextConverterStrategy
    {
        string Description { get; }

        string Convert(string input);
    }
}