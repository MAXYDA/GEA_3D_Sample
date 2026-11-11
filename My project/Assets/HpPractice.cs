using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp;
    public int maxHp;

    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("HP " + a + "%");
    }
}