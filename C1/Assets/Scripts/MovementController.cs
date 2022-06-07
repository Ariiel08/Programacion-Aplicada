using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    float _speedY = 20f;
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIM_Y = -4.25f, MAX_LIM_Y = 4.25f;

    void Update()
    {
        _deltaPos.y = Input.GetAxis("Vertical") * _speedY * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x, 
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y),
            gameObject.transform.position.z);
    }
}
