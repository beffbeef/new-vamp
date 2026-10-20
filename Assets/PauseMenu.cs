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
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            contaner.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ResumeButton()
    {
        
        
            contaner.SetActive(false);
            Time.timeScale = 1f;
        

    }


    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("MainMeny");


    }







}
