
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;
    public int currentXP = 0;
    public int requiredXP = 10;

    public void AddXP(int xp)
    {
        currentXP = currentXP + xp;

        Debug.Log("Current XP: " + currentXP);

        if (currentXP >= requiredXP)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        currentXP = currentXP - requiredXP;

        level = level + 1;

        requiredXP = requiredXP + 5;

        Debug.Log("Level up! New level: " + level);
    }
}
