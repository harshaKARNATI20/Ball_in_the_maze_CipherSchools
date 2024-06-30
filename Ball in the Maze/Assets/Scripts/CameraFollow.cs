using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private void Update()
    {
        // Position of camera  = position of target + offset
        transform.position = target.position + offset;

    }
}
