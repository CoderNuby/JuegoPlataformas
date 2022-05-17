using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float smootheVelocity = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 posicionPlayer = target.position + offset;
        Vector3 smoothedCamera = Vector3.Lerp(transform.position, posicionPlayer, smootheVelocity);
        transform.position = smoothedCamera;
    }
}
