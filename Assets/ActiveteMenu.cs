using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveteMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject menu;

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

    void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
