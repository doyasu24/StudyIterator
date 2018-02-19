using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class CoroutineSample : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(MyCoroutine());
        }

        IEnumerator MyCoroutine()
        {
            Debug.Log("Coroutine: " + Time.frameCount);
            yield return null;
            Debug.Log("Coroutine: " + Time.frameCount);
            yield return null;
            Debug.Log("Coroutine: " + Time.frameCount);
        }
    }
}