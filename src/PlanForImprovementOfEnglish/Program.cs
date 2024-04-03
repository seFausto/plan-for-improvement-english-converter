// See https://aka.ms/new-console-template for more information

using PlanForImprovementEnglishConverter;
var input = "nice, nick, price, space, cup, actually";

var conv = new TextConverter(new YearOneConverterStrategy());
Console.WriteLine(input);
Console.WriteLine(conv.Convert(input));
