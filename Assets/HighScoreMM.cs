using TMPro;
using UnityEngine;

public class HighScoreMM : MonoBehaviour
{
    public TextMeshProUGUI HighscoreMM;

    void Start()
    {
        float highscore = PlayerPrefs.GetFloat("highscore", 0);

        Debug.Log("Main menu loaded highscore: " + highscore);

        if (HighscoreMM != null)
        {
            HighscoreMM.text = "HIGHSCORE: " + highscore.ToString();
        }
        else
        {
            Debug.LogError("HighscoreMM TextMeshPro reference is missing!");
        }
    }
}