using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionCatching : MonoBehaviour
{
    [SerializeField] Transform LinkedObject;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Debug.Log("Attempting bad code");
            
            LinkedObject.Rotate(50, 50, 50);

            // Transform tempTransform = null;
            // tempTransform.Rotate(50, 50, 50);

            Debug.Log("Ran bad code");
        }
        catch(UnassignedReferenceException ex)
        {
            Debug.LogError("Exception was caught and handled");
        }
        catch (System.Exception ex)
        {
//            Debug.Log("Code cause exception: " + ex.Message);
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
