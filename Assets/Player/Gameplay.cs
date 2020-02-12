using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameplay : MonoBehaviour
{
    private bool loosingStarted = false;


    public float score;
    private float timer = 5f;
    private float secondTimer = 5f;

    private bool letsSmoke = false;

    private float defaultTimer;

    public float defaultDamage = 40;

    public float damage;
    private bool clicked = false;
    public bool isUSSR = false;
    private float resourceDefault;
    public float resource;


    public void ResetCountries()
    {
        isUSSR = false;
        resource = resourceDefault;
    }
    public bool secondChance;
    public void TakeDamage(float damage)
    {
        score += damage;
        if (isUSSR)
        {
            resource += damage;
        }
        else
        {
            resource -= damage;
        }
        if (resource <= 0)
        {
            isUSSR = true;
            loosingStarted = true;
            resource = resourceDefault / 3;
        }
    }

    public void OnMouseDown()
    {
        TakeDamage(defaultDamage);

    }

    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            resource += GetComponent<MeshFilter>().mesh.bounds.size[i];
        }
        if (resource < 50)
        {
            resource *= 10;
        }
        if (resource < 10)
        {
            resource *= 5;
        }
        resourceDefault = resource;
        damage = defaultDamage;

    }

    void Update()
    {
       
    }
}
