using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float yOffset = 0f;
    private float MIN_LIM_X = 6.39f, MAX_LIM_X = 93.50f;
    private float MIN_LIM_Y = 3.65f, MAX_LIM_Y = 31.20f;
    public float FollowSpeed = 10f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        Vector3 newPos = new Vector3(Mathf.Clamp(player.position.x, MIN_LIM_X, MAX_LIM_X), Mathf.Clamp(player.position.y, MIN_LIM_Y, MAX_LIM_Y) + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
