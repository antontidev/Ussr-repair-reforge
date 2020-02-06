using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    public Material material;
    private MeshRenderer meshRenderer;
    public Material defaultMaterial;

    public float axisToMove = 0.5f;
    private void OnMouseEnter()
    {
        meshRenderer.material = material;
        int multiplier;
        if (transform.position.z > 0)
            multiplier = -1;
        else
            multiplier = 1;
        transform.position += Vector3.forward * multiplier * axisToMove; ;
    }

    private void OnMouseExit()
    {
        meshRenderer.material = defaultMaterial;
        int multiplier;
        if (transform.position.z > 0)
            multiplier = -1;
        else
            multiplier = 1;
        transform.position += Vector3.back * multiplier * axisToMove;
    }
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
