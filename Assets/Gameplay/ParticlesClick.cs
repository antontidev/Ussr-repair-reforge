using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticlesClick : MonoBehaviour
{
    private ParticleSystem particle;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !menu.activeSelf)
        {
            particle.Play();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            particle.Stop();
        }
    }
}
