using UnityEngine;

namespace WithoutDesignPattern
{
    public class WithoutDesignPatternSample : MonoBehaviour
    {
        void Start()
        {
            var allData = new[] { 1, 2, 3 };
            for (var i = 0; i < allData.Length;i++)
            {
                var data = allData[i];
                Debug.Log("AllData: " + data);
            }
        }
    }
}