using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float _speedY = 2;
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIM = -4, MAX_LIM = 4;


    // Update is called once per frame
    void Update()
    {
        _deltaPos.y = Input.touchSupported && Input.touchCount > 0 ? Input.GetTouch(0).position.y : 0;
        _deltaPos.y *= _speedY;
        _deltaPos *=  Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x,
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM, MAX_LIM),
            gameObject.transform.position.z);
    }
}
