using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Rotation speed in degrees per second

    void Update()
    {
        // Rotate the object around the Y axis in the world space
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }
}
