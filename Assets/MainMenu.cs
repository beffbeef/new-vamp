using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1f;
    }

    public void PlayGame()
    {
        PlayerLevel.newRun = true;

        Time.timeScale = 1f;

        SceneManager.LoadScene("Game");
    }

    public void Mainmeny()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMeny");
    }

    public void Quit()
    {
        Application.Quit();
    }
}