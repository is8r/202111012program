using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchSphere : MonoBehaviour
{
    public GameObject[] items; 

    void Start()
    {
        for (int i = 0; i < items.Length; i++)
        {
            GameObject item = items[i];

            if(item.name == "Sphere (21)")
            {
                item.transform.localScale = Vector3.one * 2;
            }
        }
    }
}
