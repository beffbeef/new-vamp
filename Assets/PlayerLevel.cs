using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;
    public float currentExp = 0;
    public float requiredExp = 10;

    public Slider slider;

    private void Start()
    {
       
        slider.value = currentExp;
        slider.maxValue =requiredExp;
    }
    public void AddXP(float xp)
    {
        currentExp = currentExp + xp;

        slider.value = currentExp;

        Debug.Log("Current XP: " + currentExp);

        if (currentExp >= requiredExp)
        {
            LevelUp();
        }

    }

    public void LevelUp()
    {
        currentExp = currentExp - requiredExp;

        level = level + 1;

        requiredExp = requiredExp + 5;

        slider.maxValue = requiredExp;

        Debug.Log("Level up! New level: " + level);

    }
}
