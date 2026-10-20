using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    private float score = 0;
    private float highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f;

        highscore = PlayerPrefs.GetFloat("highscore", 0);

        Debug.Log("Loaded highscore: " + highscore);

        scoreText.text = score.ToString() + " Score";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoints()
    {
        score += 1;

        scoreText.text = score.ToString() + " Score";

        Debug.Log("Current score: " + score);

        if (score > highscore)
        {
            highscore = score;

            highscoreText.text = "HIGHSCORE: " + highscore.ToString();

            PlayerPrefs.SetFloat("highscore", highscore);
            PlayerPrefs.Save();

            Debug.Log("New highscore saved: " + PlayerPrefs.GetFloat("highscore", 0));
        }
    }
}