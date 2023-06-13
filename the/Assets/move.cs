using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class move : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0 * Time.deltaTime, 0, -3);
     
        if(Input.GetKey(KeyCode.A))
        { rb.AddForce(1000 * Time.deltaTime, 0, 0); }
        if (Input.GetKey(KeyCode.D))
        { rb.AddForce(-1000 * Time.deltaTime, 0, 0); }
        if (Input.GetKey(KeyCode.W))
        { rb.AddForce(0 * Time.deltaTime, 5, 0); }
        if (Input.GetKey(KeyCode.S))
        { rb.AddForce(0 * Time.deltaTime, -5, 0); }
    }
}
