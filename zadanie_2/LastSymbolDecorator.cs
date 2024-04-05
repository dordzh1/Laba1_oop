using System.Text;

namespace zadanie_2
{
    internal class LastSymbolDecorator : Decorator
    {
        private string _symbol;

        public LastSymbolDecorator(IDateTime datetime, string symbol) : base(datetime)
        {
            _symbol = symbol;
        }
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_datetime.Print());
            sb.Append($" {_symbol}");
            return sb.ToString();
        }
    }
}
