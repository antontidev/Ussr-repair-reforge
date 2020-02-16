using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UssrManager : MonoBehaviour
{
    public TMP_Text text;
    public Transform ussrTransform;
    public SortedDictionary<int, KeyValuePair<string, Gameplay>> countries;
    // Start is called before the first frame update
    void Start()
    {
        countries = new SortedDictionary<int, KeyValuePair<string, Gameplay>>();
        int i = 0;
        foreach(Transform element in ussrTransform)
        {
            countries.Add(i++, new KeyValuePair<string,Gameplay>(element.gameObject.name, element.GetComponent<Gameplay>()));
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "";
        for (int i = 0; i < countries.Count; i++)
        {
            if (countries[i].Value.isUSSR)
            {
                text.text += "You occupied " + countries[i].Key + "\n";
            }
        }
    }
}
