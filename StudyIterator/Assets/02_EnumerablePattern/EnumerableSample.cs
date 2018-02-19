using System.Collections.Generic;
using UnityEngine;

namespace EnumerablePattern
{
    public class EnumerableSample : MonoBehaviour
    {
        void Start()
        {
            IEnumerable<int> stream = new InfiniteSingleDataStream<int>(1);
            LogElements(stream, 3);
            LogElementsUsingForeach(stream, 3);
        }

        void LogElements<T>(IEnumerable<T> enumerable, int max)
        {
            IEnumerator<T> enumerator = enumerable.GetEnumerator();
            var count = 0;
            while (enumerator.MoveNext())
            {
                Debug.Log("Enumerator: " + enumerator.Current);
                count += 1;
                if (count >= max)
                    return;
            }
        }

        void LogElementsUsingForeach<T>(IEnumerable<T> enumerable, int max)
        {
            // foreachはIEnumerableを反復してくれる糖衣構文
            // コンパイル時に while(enumerator.MoveNext()) に相当するコードになる
            var count = 0;
            foreach(var e in enumerable)
            {
                Debug.Log("EnumeratorForeach: " + e);
                count += 1;
                if (count >= max)
                    return;
            }
        }
    }
}