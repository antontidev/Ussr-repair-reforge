using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicksound : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource source;
    void Start()
    {
        source = GetComponent <AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
	if (Input.GetMouseButtonUp(0))
	{
		source.Play();
	}
	if (Input.GetMouseButtonDown(0))
	{
		source.Stop();
	}
    }
}
