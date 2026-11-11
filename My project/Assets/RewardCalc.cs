using UnityEngine;
public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        int hour = playSeconds / 3600;
        int min = (playSeconds % 3600) / 60;
        int sec = playSeconds % 60;
        Debug.Log(hour + ":" + (min / 10) + (min % 10) + ":" + (sec / 10) + (sec % 10));

        int goldPerMember = gold / members;
        int leaderBonus = gold % members;
        Debug.Log("1인당 골드: " + goldPerMember + ", 리더 보너스: " + leaderBonus);

        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log("기본 경험치: " + baseExp + ", 최종 경험치: " + finalExp);

        int level = finalExp / 100 + 1;
        int remainExp = 100 - (finalExp % 100);
        Debug.Log("레벨: " + level + ", 다음 레벨까지: " + remainExp);

        float averageDamage = (float)totalDamage / hits;
        Debug.Log("평균 데미지: " + averageDamage);
    }
}
