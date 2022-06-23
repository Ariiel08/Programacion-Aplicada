using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector3 _movementSpeed = new Vector3(10, 0);
    static float plusTime;
    static bool isFast = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= plusTime && isFast)
        {
            _movementSpeed = new Vector3(10, 0);
            isFast = false;
        }
    }

    public static void IncrementSpeed()
    {
        _movementSpeed = new Vector3(20, 0);
        isFast = true;
        plusTime = Time.time + 5;
    }
}
