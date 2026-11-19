using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    [ContextMenu("List")]
    void ListBasic()
    {
        List<string> items = new List<string>();
        items.Add("포션");
        items.Add("화살");
        items.Remove("포션");
        Debug.Log(items.Count + " " + items[0]);
    }
    [ContextMenu("예측 2")]
    void Predict2()
    {
        List<int> nums = new List<int>();
        nums.Add(5);
        nums.Add(3);
        nums.Add(5);
        nums.Remove(5);
        Debug.Log(nums.Count);
        Debug.Log(nums[0]);
        nums.RemoveAt(0);
        Debug.Log(nums[0]);
        Debug.Log(nums.Contains(3));
    }

}
