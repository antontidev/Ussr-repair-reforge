﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                Debug.Log(raycastHit.transform.gameObject.name);
            }
        }
    }
}
