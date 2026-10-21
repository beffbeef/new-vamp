
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    private void Awake()
    {
       Time.timeScale = 1.0f;
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void Mainmeny()
    {
        SceneManager.LoadSceneAsync("MainMeny");
    }


    public void Quit()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
