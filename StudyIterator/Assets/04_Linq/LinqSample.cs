using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Linq
{
    public class LinqSample : MonoBehaviour
    {
        void Start()
        {
            IEnumerable<int> range = Range(1, 3);
            foreach (var i in range)
            {
                Debug.Log("Range: " + i);
            }

            IEnumerable<int> rangeTake = Range(1, 3).Take(2);
            foreach (var i in rangeTake)
            {
                Debug.Log("RangeTake: " + i);
            }

            IEnumerable<int> headLast = Range(1, 3).MyQuery();
            foreach (var i in headLast)
            {
                Debug.Log("HeadLast: " + i);
            }
        }

        IEnumerable<int> Range(int from, int to)
        {
            var count = from;
            while (count <= to)
            {
                yield return count;
                count += 1;
            }
        }
    }
}