using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutine
{
    /// <summary>
    /// UniRxのMainThreadDispathcerの超簡易版。ガバガバ実装。
    /// </summary>
    public class CoroutineDispatcher : MonoBehaviour
    {
        List<IEnumerator> coroutines = new List<IEnumerator>();

        void Update()
        {
            var newList = new List<IEnumerator>();
            foreach (var c in coroutines)
            {
                if (c.MoveNext())
                    newList.Add(c);
            }
            coroutines = newList;
        }

        public void AddCoroutine(IEnumerator enumerator)
        {
            coroutines.Add(enumerator);
        }

        public void RemoveCoroutine(IEnumerator enumerator)
        {
            coroutines.Remove(enumerator);
        }
    }
}