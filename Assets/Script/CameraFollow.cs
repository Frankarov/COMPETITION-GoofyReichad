using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float speed = 0.125f;

    private Vector3 offset = new Vector3(0f,3f,0f);

    private void FixedUpdate()
    {
        Vector3 currentPosition = target.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, currentPosition, speed);

        transform.position = new Vector3(transform.position.x, smoothPosition.y, transform.position.z);
    }

    
}
