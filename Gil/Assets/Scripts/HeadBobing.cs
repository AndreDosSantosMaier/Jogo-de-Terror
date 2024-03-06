using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobing : MonoBehaviour
{
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            startBob();
        }
        if (Input.GetKey(KeyCode.A))
        {
            startBob();
        }
        if (Input.GetKey(KeyCode.S))
        {
            startBob();
        }
        if (Input.GetKey(KeyCode.D))
        {
            startBob();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            stpoBob();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            stpoBob();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            stpoBob();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            stpoBob();
        }
    }
    void startBob()
    {
        Camera.GetComponent<Animator>().Play("HeadBobing");
    }
    void stpoBob()
    {
       Camera.GetComponent<Animator>().Play("New State");
    }
}

