using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string mainMenuScene;
    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                isPaused = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1.0f;

            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                isPaused = true;
                Time.timeScale = 0.0f;
                pauseMenu.SetActive(true);
            }
        }
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void ReturntoMain()
    {
        SceneManager.LoadScene(mainMenuScene);

    }
}
