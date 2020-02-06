using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HummerController : MonoBehaviour
{
    private Gameplay gameplay;
    public Transform hummer;
    private Vector3 offsetOfCenterObject;
    public Vector3 pointOutsideScreen;
    public float speed = 5f;
    public float distance = 100f;
    // Start is called before the first frame update
    void Start()
    {
        if (hummer == null)
            hummer = transform.Find("hummer");
        
        gameplay = GetComponent<Gameplay>();

        if (hummer.position.z > 0)
            distance *= -1f;
        else
            distance *= 1f;
        offsetOfCenterObject = hummer.position - transform.position;

        pointOutsideScreen = hummer.position = new Vector3(hummer.position.x, hummer.position.y, hummer.position.z + distance);// pointOutsideScreen;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameplay.isUssr)
        {
            if (Vector3.Distance(hummer.position, transform.position + offsetOfCenterObject) > 0.01f)
            {
                hummer.position = Vector3.Lerp(hummer.position, transform.position + offsetOfCenterObject, speed * Time.deltaTime);
            }
        }
        else
        {
            //dissolve will be better
            if (Vector3.Distance(hummer.position, pointOutsideScreen) > 0.01f)
            {
                hummer.position = Vector3.Lerp(hummer.position, pointOutsideScreen, speed * Time.deltaTime);
            }
        }
    }
}