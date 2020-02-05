using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public float startTimeScale;

    public float endTimeScale;

    [Range(0f, 1f)]
    public float smoothingEffect;

    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        isPaused = gameObject.activeInHierarchy;
        if (gameObject.activeInHierarchy)
        {
            if (isPaused)
            {
                //Time.timeScale = Mathf.Lerp(Time.timeScale, startTimeScale, Time.deltaTime * smoothingEffect);
                Time.timeScale = 0f;

                //StartCoroutine(Pause());
            }
            else
            {
                //Time.timeScale = Mathf.Lerp(Time.timeScale, endTimeScale, Time.deltaTime * smoothingEffect);
                Time.timeScale = 1f;
                //StartCoroutine(Resume());
            }
        }*/
    }

    IEnumerator Pause()
    {

    
        return null;
    }
    IEnumerator Resume()
    {
        return null;
    }
}
