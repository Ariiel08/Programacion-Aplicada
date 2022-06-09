using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInstantiator : MonoBehaviour
{
    public GameObject RedSphere, GreenSphere, BlueSphere;
    GameObject Sphere;
    Vector3 _startingPosition = new Vector3(-11, 0);
    float _nextTime;
    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_Y = -4.25f, MAX_Y = 4.25f;

    void Start()
    {
        _nextTime = GetNextTime();
    }

    void Update()
    {
        if (Time.time > _nextTime)
        {
            _startingPosition.y = Random.Range(MIN_Y, MAX_Y);
            Sphere = Instantiate(NextSphere(), _startingPosition, Quaternion.identity);
            _nextTime = GetNextTime();
        }
    }

    float GetNextTime()
    {
        return Time.time + (Random.Range(MIN_TIME, MAX_TIME));
    }

    GameObject NextSphere()
    {

        switch (Random.Range(0, 4))
        {
            case 0:
                return RedSphere;
            case 1:
                return BlueSphere;
            default:
                return GreenSphere;

        }
    }
}