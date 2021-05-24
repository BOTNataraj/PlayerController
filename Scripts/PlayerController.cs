using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xForce = 10.0f;
    public float zForce = 10.0f;

    void Update()
    {
        float x = 0.0f;
        if (Input.GetKey(KeyCode.D))
        {
            x = x + xForce;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x = x - xForce;
        }

        float z = 0.0f;
        if (Input.GetKey(KeyCode.W))
        {
            z = z + zForce;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = z - zForce;
        }

        GetComponent<Rigidbody>().AddForce(x, 0.0f, z);

    }
}
