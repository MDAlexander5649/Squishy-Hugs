using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ReturnToMainMenu ()
    {
        SceneManager.LoadScene("Scenes/UI");
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
        SceneManager.LoadScene("Scenes/UI");
    }
}
