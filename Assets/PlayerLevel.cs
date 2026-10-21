using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public static bool newRun = true;

    public int level = 1;
    public float currentExp = 0f;
    public float requiredExp = 10f;

    public Slider slider;

    public Bullet bullet;
    public PlayerShoot playershoot;
    public movment_real movment_real;

    private void Start()
    {
        if (newRun)
        {
            ResetUpgrades();
            newRun = false;
        }

        slider.maxValue = requiredExp;
        slider.value = currentExp;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void AddEXP(float Exp)
    {
        currentExp += Exp;

        Debug.Log("Current EXP: " + currentExp);

        if (currentExp >= requiredExp)
        {
            LevelUp();
        }

        slider.value = currentExp;
    }

    public void LevelUp()
    {
        if (SceneManager.GetSceneByName("LevelUpHud").isLoaded)
        {
            Debug.LogWarning("Level-up menu is already open.");
            return;
        }

        currentExp -= requiredExp;
        level++;
        requiredExp += 5f;

        slider.maxValue = requiredExp;
        slider.value = currentExp;

        Debug.Log("Level up! New level: " + level);

        Time.timeScale = 0f;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        SceneManager.LoadScene(
            "LevelUpHud",
            LoadSceneMode.Additive
        );
    }

    public void AttackSpeedUp()
    {
        playershoot.fireRate =
            Mathf.Max(0.1f, playershoot.fireRate - 0.1f);

        

        LeveelUpResume();
    }

    public void DamageUp()
    {
        bullet.damage += 25;

        

        LeveelUpResume();
    }

    public void SpeedUp()
    {
        movment_real._moveSpeed += 1f;

       

        LeveelUpResume();
    }

    public void ResetUpgrades()
    {
        
        movment_real._moveSpeed = 5f;

        playershoot.fireRate = 0.8f;

        bullet.damage = 50;

        level = 1;
        currentExp = 0f;
        requiredExp = 10f;

        slider.maxValue = requiredExp;
        slider.value = currentExp;

       
    }

    public void LeveelUpResume()
    {
        if (SceneManager.GetSceneByName("LevelUpHud").isLoaded)
        {
            SceneManager.UnloadSceneAsync("LevelUpHud");
        }

        Time.timeScale = 1f;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}