﻿using System.Text;

namespace zadanie_2
{
    internal class FirstSymbolDecorator: Decorator
    {
        private string _symbol;

        public FirstSymbolDecorator(IDateTime datetime, string symbol): base(datetime)
        {
            _symbol = symbol;
        }
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_symbol);
            sb.Append(_datetime.Print());
            return sb.ToString();
        }
    }
}
