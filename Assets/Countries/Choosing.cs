using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    public Material material;
    private MeshRenderer meshRenderer;
    public Material defaultMaterial;

    private void OnMouseEnter()
    {
        meshRenderer.material = material;
    }

    private void OnMouseExit()
    {
        meshRenderer.material = defaultMaterial;
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
