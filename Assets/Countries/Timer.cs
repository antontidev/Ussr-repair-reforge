using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float time;
    public ActiveteMenu menu;
    public TMP_Text text;
    public UssrManager manager;
    private float defaultTime;
    // Update is called once per frame
    private void Start()
    {
        defaultTime = time;
    }
    void Update()
    {
        time -= Time.deltaTime;
        if (time < Time.deltaTime)
        {
            menu.Pause();
            for (int i = 0; i < manager.countries.Count; i++)
            {
                manager.countries[i].Value.ResetCountries();
            }
            time = defaultTime;
        }

        text.text = Mathf.Round(time).ToString();
    }
}
