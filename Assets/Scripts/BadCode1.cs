using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCode1 : MonoBehaviour
{
    [SerializeField] Transform LinkedObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Prepare to run bad code!");

        BadFunction();

        Debug.Log("I ran the bad code!");
    }

    void BadFunction()
    {
        LinkedObject.Rotate(100, 100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
