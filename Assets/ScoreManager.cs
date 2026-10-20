using TMPro;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    float score =0;
    float highscore =0;

    private void Awake()
    {
       instance = this;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);

        scoreText.text = score.ToString() + " Score";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();

    }

  
    public void AddPoints()
    {
        
        score += 1;
        scoreText.text = score.ToString() + " Score";
        
        if (score > highscore)
        {
            PlayerPrefs.SetFloat("highscore", score);

        }

    }


  


}
