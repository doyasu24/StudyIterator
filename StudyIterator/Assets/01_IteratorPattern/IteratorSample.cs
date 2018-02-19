using UnityEngine;

namespace IteratorPattern
{
    public class IteratorSample : MonoBehaviour
    {
        void Start()
        {
            // 全データを閲覧したい
            IAggregate<int> aggregate = CreateAggregate();
            IIterator<int> iterator = aggregate.Iterator;
            LogAllElements(iterator);
        }

        void LogAllElements<T>(IIterator<T> iterator)
        {
            // どんなデータ構造か隠蔽されている
            // どんな順番でアクセスするか隠蔽されている
            while (iterator.HasNext)
            {
                Debug.Log("Iterate: " + iterator.Next());
            }
        }

        // 何かデータの集まり
        IAggregate<int> CreateAggregate()
        {
            var aggregate = new ConcreteAggregate<int>(10);
            aggregate.Add(1);
            aggregate.Add(2);
            aggregate.Add(3);
            return aggregate;
        }
    }
}