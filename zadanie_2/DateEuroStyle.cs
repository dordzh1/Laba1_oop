using System.Globalization;

namespace zadanie_2
{
    internal class DateEuroStyle: IDateTime
    {
        public string Print()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
