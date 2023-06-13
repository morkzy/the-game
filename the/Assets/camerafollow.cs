using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    public Vector3 cam;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cam;
    }
}
