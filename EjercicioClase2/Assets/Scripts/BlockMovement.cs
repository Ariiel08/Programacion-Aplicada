using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    const float MAX_X = 12f;
    Vector3 currentPosition = new Vector3();
    const float speed_x = 8f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition.x = -6 + Mathf.PingPong(Time.time * speed_x, MAX_X);
        currentPosition.y = -2;
        gameObject.transform.position = currentPosition;
    }
}
