
namespace zadanie_2
{
    internal abstract class Decorator : IDateTime
    {
        protected IDateTime _datetime;
        public Decorator(IDateTime datetime)
        {
            _datetime = datetime;
        }
        public abstract string Print();
    }
}
