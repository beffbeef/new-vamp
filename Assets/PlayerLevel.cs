using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        slider.maxValue =requiredExp;
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
        currentExp = currentExp - requiredExp;

        level = level + 1;

        requiredExp = requiredExp + 5;

        slider.maxValue = requiredExp;

        Debug.Log("Level up! New level: " + level);

        if (SceneManager.GetSceneByName("LevelUpHud").IsValid())
        {
            Debug.LogWarning("Level is alredy open. Blocking dups");
            return;
        }
        SceneManager.LoadScene("LevelUpHud", LoadSceneMode.Additive);
        Time.timeScale = 0f;
        



    }

    public void LeveelUpResume()
    {

        SceneManager.UnloadSceneAsync("LevelUpHud");
        Time.timeScale = 1f;


    }










}
