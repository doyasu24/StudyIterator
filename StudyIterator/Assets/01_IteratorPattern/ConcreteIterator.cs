namespace IteratorPattern
{
    /// <summary>
    /// ConcreteAggregate<T>の反復子
    /// </summary>
    public class ConcreteIterator<T> : IIterator<T>
    {
        ConcreteAggregate<T> aggregate;
        int index = 0;

        public bool HasNext { get { return aggregate.Length > index; } }

        public T Next()
        {
            var t = aggregate.GetAt(index);
            index += 1;
            return t;
        }

        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            this.aggregate = aggregate;
        }
    }
}