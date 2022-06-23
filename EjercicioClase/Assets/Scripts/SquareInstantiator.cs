using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareInstantiator : MonoBehaviour
{
    public GameObject RedCube, GreenCube, BlueCube, PinkCube, SkyBlueCube;
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
            Instantiate(NextCube(), _startingPosition, Quaternion.identity);
            _nextTime = GetNextTime();
        }
    }

    float GetNextTime()
    {
        return Time.time + (Random.Range(MIN_TIME, MAX_TIME));
    }

    GameObject NextCube()
    {

        switch (Random.Range(0, 5))
        {
            case 0:
                return RedCube;
            case 1:
                return BlueCube;
            case 2:
                return GreenCube;
            case 3:
                return SkyBlueCube;
            default:
                return PinkCube;

        }
    }
}
