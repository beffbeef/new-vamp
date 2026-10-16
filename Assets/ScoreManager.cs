using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score =0;
    int highscore =0;

    private void Awake()
    {
       instance = this;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);

        scoreText.text = score.ToString() + " Score";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();

    }

  
    public void AddPoints()
    {
        
        score += 1;
        scoreText.text = score.ToString() + " Score";
        
        if (score > highscore)
        {
            PlayerPrefs.SetInt("highscore", score);

        }

    }


    //Need to fix score reset


}
