using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class DispatchSample : MonoBehaviour
    {
        [SerializeField]
        CoroutineDispatcher dispatcher;

        void Start()
        {
            dispatcher.AddCoroutine(MyCoroutine());
        }

        IEnumerator MyCoroutine()
        {
            Debug.Log("Dispatcher: " + Time.frameCount);
            yield return null;
            Debug.Log("Dispatcher: " + Time.frameCount);
            yield return null;
            Debug.Log("Dispatcher: " + Time.frameCount);
        }
    }
}