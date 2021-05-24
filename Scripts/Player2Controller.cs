using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float xForce = 10.0f;
    public float zForce = 10.0f;

    void Update()
    {
        float x = 0.0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = x + xForce;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = x - xForce;
        }

        float z = 0.0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z = z + zForce;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z = z - zForce;
        }

        GetComponent<Rigidbody>().AddForce(x, 0.0f, z);

    }
}
