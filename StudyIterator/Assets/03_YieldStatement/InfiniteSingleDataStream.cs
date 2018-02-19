#pragma warning disable RECS0135 // 関数は、可能な実行パスのいずれかを通じて末尾または 'return' ステートメントに到達しません

using System.Collections;
using System.Collections.Generic;

namespace YieldStatement
{
    public class InfiniteSingleDataStream<T> : IEnumerable<T>
    {
        readonly T data;

        public InfiniteSingleDataStream(T data)
        {
            this.data = data;
        }

        // yield文でGetEnumerator()を実装するとIEnumerator<T>の実装が要らない
        public IEnumerator<T> GetEnumerator()
        {
            while (true)
                yield return data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
#pragma warning restore RECS0135
