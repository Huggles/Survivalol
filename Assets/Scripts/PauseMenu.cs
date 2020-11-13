using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject player;

    public GameObject enemies;

    public GameObject food;

    public void ResignGame()
    {
        SceneManager.LoadScene(0);
        Resume();
    }

    public void QuitGame()
    {
        UnityEngine.Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ResumeGame()
    {
        Resume();
    }

    // Update is called once per frame
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
    
    void Resume()
    {
        UnityEngine.Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        player.SetActive(true);
        enemies.SetActive(true);
        food.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        UnityEngine.Debug.Log("Pause");
        pauseMenuUI.SetActive(true);
        player.SetActive(false);
        enemies.SetActive(false);
        food.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}