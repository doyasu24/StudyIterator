namespace IteratorPattern
{
    public class ReverceIterator<T> : IIterator<T>
    {
        ConcreteAggregate<T> aggregate;
        int index;

        public bool HasNext { get { return index >= 0; } }

        public T Next()
        {
            var t = aggregate.GetAt(index);
            index -= 1;
            return t;
        }

        public ReverceIterator(ConcreteAggregate<T> aggregate)
        {
            this.aggregate = aggregate;
            index = aggregate.Length - 1;
        }
    }
}