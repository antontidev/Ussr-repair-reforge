using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public CameraShacker shacker;
    public bool isUssr = false;
    public float resource = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        if (isUssr)
        {
            StartCoroutine(shacker.Shake(0.15f, 0.4f));
        }
    }
    private void OnMouseDown()
    {
        isUssr = !isUssr;
    }

}
