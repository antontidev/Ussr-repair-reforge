﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public CameraShacker shacker;
    public bool isUssr = true;
    public float resource = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resource <= 0f)
        {
            isUssr = true;
            shacker.Shake();
        }
    }
}
