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

    public float height;
    public float weigth;

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
        /*xRot += Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
        yRot += Input.GetAxis("Mouse X") * speed * Time.deltaTime;

        transform.position += Quaternion.Euler(xRot, yRot, 0f) * Vector3.one;
        transform.LookAt(objectToMove);*/
    }
}
