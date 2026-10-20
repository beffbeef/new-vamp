
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    private void Awake()
    {
       
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
