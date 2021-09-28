using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionThrowing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("About to throw exception!");
        
        throw new System.InvalidOperationException("Intentionally throwing exception");

        Debug.Log("Did not run!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
