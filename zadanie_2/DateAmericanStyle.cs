using System.Globalization;

namespace zadanie_2
{
    internal class DateAmericanStyle : IDateTime
    {
        public string Print()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
