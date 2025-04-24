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
    public void RestartLevel()
    {
        // Garante que o tempo volte ao normal antes de reiniciar
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReturnMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
