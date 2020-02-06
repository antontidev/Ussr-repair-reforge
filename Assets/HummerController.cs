using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HummerController : MonoBehaviour
{
    private Gameplay gameplay;
    public Transform hummer;
    public Vector3 offsetOfCenterObject;
    public Vector3 pointOutsideScreen;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (hummer == null)
            hummer = transform.Find("hummer");
        gameplay = GetComponent<Gameplay>();
        offsetOfCenterObject = hummer.position;
        //hummer.position = pointOutsideScreen;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(transform.position + offsetOfCenterObject, hummer.position) > 0.01f)
        {
   //         hummer.position = Vector3.MoveTowards(hummer.position, transform.position + offsetOfCenterObject, speed * Time.deltaTime);
        }
    }
}