using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMovement : MonoBehaviour
{
    public Vector3 cameraOffset;
    public Transform player;

    [Range(0f, 1f)]
    public float smoothing;
    public float speed = 5f;

    private void Start()
    {
        cameraOffset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        //Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speed, Vector3.up);
        float x = Input.GetAxis("Mouse Y");
        float y = Input.GetAxis("Mouse X");
        if (Mathf.Abs(y) > 160)
            y = transform.rotation.y;
        else
            y *= speed;
        Quaternion camTurnAngle = Quaternion.Euler(x * speed, y, 0);

        cameraOffset = camTurnAngle * cameraOffset;
        Vector3 newPos = player.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothing);

        transform.LookAt(player);
    }

}
