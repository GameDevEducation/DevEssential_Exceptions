using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCustomException : System.Exception
{
    public string FileName;

    public DemoCustomException() : base()
    {

    }

    public DemoCustomException(string message) : base(message)
    {

    }

    public DemoCustomException(string message, System.Exception innerException) : base(message, innerException)
    {

    }

    public DemoCustomException(string message, System.Exception innerException, string fileName) :
        base(message, innerException)
    {
        FileName = fileName;
    }
}

public class CustomExceptionThrowing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            throw new DemoCustomException("Test", null, "Test.txt");
        }
        catch (DemoCustomException dce)
        {
            Debug.Log(dce.FileName);
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
