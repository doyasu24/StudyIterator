using System.Collections;
using System.Collections.Generic;

namespace EnumerablePattern
{
    /// <summary>
    /// 同じデータを流し続ける無限ストリーム
    /// </summary>
    public class InfiniteSingleDataStream<T> : IEnumerable<T>
    {
        public readonly T Data;
        public InfiniteSingleDataStream(T data)
        {
            Data = data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new InfiniteSingleDataStreamEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new InfiniteSingleDataStreamEnumerator<T>(this);
        }
    }
}