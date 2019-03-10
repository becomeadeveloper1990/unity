using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            print("Space pressed.");
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating left.");
        } else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating right.");
        }
    }
}
