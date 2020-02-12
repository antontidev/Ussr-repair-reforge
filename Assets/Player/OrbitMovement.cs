using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMovement : MonoBehaviour
{
    public float pitch = 0.0f;
    public float speed = 5f;
    public float yaw = 0.0f;
    private void Start()
    {
    }

    private void Update()
    {

    }

    private void LateUpdate()
    {

        float movementX = speed * Input.GetAxis("Mouse Y") * Time.deltaTime;

        if (Mathf.Abs(pitch - movementX) < 25)
        {
            pitch -= movementX;
        }


        float movementY = speed * Input.GetAxis("Mouse X") * Time.deltaTime;
        if (Mathf.Abs(yaw + movementY) < 25)
        {
            yaw += movementY;
        }
        
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
