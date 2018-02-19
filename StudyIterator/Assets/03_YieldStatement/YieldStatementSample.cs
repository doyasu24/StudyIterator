#pragma warning disable RECS0135 // 関数は、可能な実行パスのいずれかを通じて末尾または 'return' ステートメントに到達しません

using System.Collections.Generic;
using UnityEngine;

namespace YieldStatement
{
    public class YieldStatementSample : MonoBehaviour
    {
        void Start()
        {
            var count = 0;
            foreach (var i in new InfiniteSingleDataStream<int>(1))
            {
                Debug.Log("YieldStatement: " + i);
                count += 1;
                if (count >= 3)
                    return;
            }

            // -------------------------------------------------

            count = 0;
            foreach (var i in GetInfiniteSingleDataStream(1))
            {
                Debug.Log("YieldStatement: " + i);
                count += 1;
                if (count >= 3)
                    return;
            }
        }

        // InfiniteSingleDataStreamクラスを生成するメソッド
        IEnumerable<T> GetInfiniteSingleDataStream<T>(T data)
        {
            while (true)
            {
                yield return data;
            }
        }
    }
}
#pragma warning restore RECS0135
