using TMPro;
using UnityEngine;


public class HighScore : MonoBehaviour
{

    public int currentScore;

    public float Score;
    public float Highscore;

    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI highscoretext;


    public void ChangeScore(int points)
    {
        currentScore += points;
        scoretext.text = currentScore.ToString();

    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (currentScore > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", currentScore);
        }

        scoretext = new TextMeshProUGUI();
        highscoretext.text =PlayerPrefs.GetInt("SavedHighScore").ToString();
    
    }
    // Update is called once per frame
    void Update()
    {
        

    }
}
