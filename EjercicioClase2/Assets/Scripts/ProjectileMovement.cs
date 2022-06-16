using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    Vector3 deltaPos = new Vector3();
    float initialTime, deltaT, initialSpeed = 12f;

    void Start()
    {
        initialTime = Time.time;
    }

    void Update()
    {
        deltaT = Time.time - initialTime;
        deltaPos.y = initialSpeed * deltaT + Physics.gravity.y * Mathf.Pow(deltaT, 2) / 2;
        initialSpeed += Physics.gravity.y * deltaT;
        initialTime = Time.time;
        gameObject.transform.Translate(deltaPos);
    }
}
