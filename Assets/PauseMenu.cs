using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{

    public GameObject contaner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetSceneByName("PauseMenu").IsValid())
        {
            Debug.LogWarning("Pause is alredy open. Blocking dups");
            return;

        }

       if (Keyboard.current.escapeKey.wasPressedThisFrame)
       {
        SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
        Time.timeScale = 0f;
       }
        

    }

    public void ResumeButton()
    {


        SceneManager.UnloadSceneAsync("PauseMenu");
        Time.timeScale = 1f;
        

    }


    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("MainMeny");


    }







}
