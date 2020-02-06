using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    public Material material;
    private MeshRenderer meshRenderer;
    public Material defaultMaterial;

    public float axisToMove = 0.5f;
    public float speed = 5f;
    public Vector3 defaultPosition;
    private Vector3 targetPosition;
    private void OnMouseEnter()
    {
        meshRenderer.material = material;
        StartCoroutine(MoveToChoose());
    }

    private void OnMouseExit()
    {
        meshRenderer.material = defaultMaterial;
        StartCoroutine(MoveToDefault());
    }
    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
        targetPosition = new Vector3(transform.position.x, transform.position.z + axisToMove, transform.position.y);
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator MoveToChoose()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.001f)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            yield return null;
        }
    }
    IEnumerator MoveToDefault()
    {
        while (Vector3.Distance(transform.position, defaultPosition)> 0.001f)
        {
            transform.position -= Vector3.back * speed * Time.deltaTime;
            yield return null;
        }
    }
}
