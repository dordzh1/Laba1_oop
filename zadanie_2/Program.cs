using zadanie_2;
class Program
{
    static void Main(string[] args)
    {

        //zadanie2

        IDateTime decoratedEuropeanDateTime = new LastSymbolDecorator(new FirstSymbolDecorator(new DateEuroStyle(), "^8^ "), "^_^");
        IDateTime decoratedAmericanDateTime = new LastSymbolDecorator(new FirstSymbolDecorator(new DateAmericanStyle(), "^8^ "), "^_^");

        IDateTime decorated = new FirstSymbolDecorator(decoratedAmericanDateTime, "0-0");

        Console.WriteLine("Decorated European DateTime: " + decoratedEuropeanDateTime.Print());
        Console.WriteLine("Decorated American DateTime: " + decoratedAmericanDateTime.Print());
    }
}
