using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMovement : MonoBehaviour
{
    public float speed;
    [Range(0f, 1f)]
    public float smoothingFactor;

    public Transform objectToMove;
    public Vector3 pointWithOrbit;

    private Vector3 viewOffset;
    private Vector3 cameraOffset;
    private Vector3 startNewMiddle;
    private Vector3 endNewMiddle;

    public float xRot;
    public float yRot;
    private bool changingMiddle;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - objectToMove.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            changingMiddle = true;
            startNewMiddle = Camera.main.ScreenToWorldPoint(transform.position);
        }
        else if (Input.GetMouseButtonUp(2))
        {
            changingMiddle = false;
            endNewMiddle = Camera.main.ScreenToWorldPoint(transform.position);
            //или наоборот
            viewOffset = endNewMiddle - startNewMiddle;
        }
    }
    void LateUpdate()
    {
        xRot += Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        yRot += Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        transform.position = objectToMove.position + Quaternion.Euler(xRot, yRot, 0f) * ( -Vector3.back);
        transform.LookAt(objectToMove.position, Vector3.up);
        /*if (!changingMiddle)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speed, Vector3.up); //Quaternion.Euler(Input.GetAxis("Mouse X") * speed, Input.GetAxis("Mouse Y") * speed, 0);


            cameraOffset = camTurnAngle * cameraOffset;

            Vector3 newPos = objectToMove.position + cameraOffset;

            transform.position = Vector3.Slerp(transform.position, newPos, Time.deltaTime * smoothingFactor);

            transform.LookAt(objectToMove.transform);
        }*/
    }
}
