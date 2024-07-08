namespace PlanForImprovementEnglishConverter
{
    public interface ITextConverterStrategy
    {
        string Description { get; }
        string Blurb { get; }
        string Convert(string input);
    }
}