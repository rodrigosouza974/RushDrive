using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseDisplay;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseDisplay.SetActive(false);
        Time.timeScale = 1f; // Retoma o tempo normal do jogo
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseDisplay.SetActive(true);
        Time.timeScale = 0f; // Pausa o tempo do jogo
        GameIsPaused = true;
    }
    public void ReturnMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
