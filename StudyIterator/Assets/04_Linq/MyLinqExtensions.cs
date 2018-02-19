using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class MyLinqExtensions
    {
        // LINQは以下のようなIEnumerable<T> => IEnumerable<T>の拡張メソッドの集まり
        public static IEnumerable<T> MyQuery<T>(this IEnumerable<T> stream)
        {
            var head = stream.First();
            var last = stream.Last();
            var newStream = new[] { head, last };
            return newStream;
        }
    }
}