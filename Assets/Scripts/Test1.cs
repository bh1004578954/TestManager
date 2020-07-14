using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Light>() == null)
        {
            Debug.Log("n");
        }
        else
        {
            Debug.Log("y");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
