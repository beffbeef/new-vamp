using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;
    public float currentExp = 0;
    public float requiredExp = 10;

    public Slider slider;
    public GameObject contaner;

    private void Start()
    {
        slider.value = currentExp;
        slider.maxValue = requiredExp;
    }

    public void AddEXP(float Exp)
    {
        currentExp = currentExp + Exp;

        slider.value = currentExp;

        Debug.Log("Current EXP: " + currentExp);

        if (currentExp >= requiredExp)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        if (SceneManager.GetSceneByName("LevelUpHud").isLoaded)
        {
            Debug.LogWarning("Level-up menu is already open.");
            return;
        }

        currentExp = currentExp - requiredExp;

        level = level + 1;

        requiredExp = requiredExp + 5;

        slider.maxValue = requiredExp;
        slider.value = currentExp;

        Debug.Log("Level up! New level: " + level);

        SceneManager.LoadScene("LevelUpHud", LoadSceneMode.Additive);

        Time.timeScale = 0f; 
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LeveelUpResume()
    {
        Time.timeScale = 1f;

        if (SceneManager.GetSceneByName("LevelUpHud").isLoaded)
        {
            SceneManager.UnloadSceneAsync("LevelUpHud");
        }
    }
}