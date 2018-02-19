using System.Collections;
using System.Collections.Generic;

namespace EnumerablePattern
{
    /// <summary>
    /// InfiniteSingleDataStreamの反復子
    /// </summary>
    public class InfiniteSingleDataStreamEnumerator<T> : IEnumerator<T>
    {
        readonly InfiniteSingleDataStream<T> stream;

        public InfiniteSingleDataStreamEnumerator(InfiniteSingleDataStream<T> stream)
        {
            this.stream = stream;
        }

        public T Current { get { return stream.Data; } }

        object IEnumerator.Current { get { return stream.Data; } }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {
        }
    }
}