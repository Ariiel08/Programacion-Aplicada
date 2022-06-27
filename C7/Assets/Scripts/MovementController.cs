using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    const float MAX_Y = 8f;
    const float SPPED_Y = 15f;
    Vector3 currentPositon = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPositon.y = -4 + Mathf.PingPong(Time.time * SPPED_Y, MAX_Y);
        gameObject.transform.position = currentPositon;
    }
}
