namespace IteratorPattern
{
    public interface IIterator<T>
    {
        bool HasNext { get; }
        T Next();
    }
}