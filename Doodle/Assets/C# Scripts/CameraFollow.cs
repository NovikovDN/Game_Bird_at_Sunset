using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform birdPos;


    void Update()
    {
        if (birdPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, birdPos.position.y, transform.position.z);
        }
    }
}
