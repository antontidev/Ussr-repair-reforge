using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActiveteMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject menu;
    public GameObject gameplay;

    private void Awake()
    {
        Pause();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        menu.SetActive(true);
        gameplay.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Resume()
    {
        menu.SetActive(false);
        gameplay.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
