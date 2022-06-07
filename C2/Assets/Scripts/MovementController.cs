using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Vector3 _movementSpeed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIM_Y = -4.25f, MAX_LIM_Y = 4.25f, MIN_LIM_X = -8.25f, MAX_LIM_X = 8.25f;

    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y),
            gameObject.transform.position.z);
    }
}
