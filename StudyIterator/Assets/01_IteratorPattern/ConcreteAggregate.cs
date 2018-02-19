namespace IteratorPattern
{
    /// <summary>
    /// 配列を使ったデータの集まり
    /// </summary>
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        T[] array;
        int last = 0;

        public ConcreteAggregate(int maxSize)
        {
            array = new T[maxSize];
        }

        public void Add(T t)
        {
            array[last] = t;
            last += 1;
        }

        public T GetAt(int index)
        {
            return array[index];
        }

        public int Length { get { return last; } }

        public IIterator<T> Iterator { get { return new ConcreteIterator<T>(this); } }
    }
}