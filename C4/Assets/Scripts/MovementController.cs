using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public FloatingJoystick Joystick;
    Vector3 _deltaPos = new Vector3();
    Vector3 _movementSpeed = new Vector3(10, 10);
    const float MIN_X = -9, MAX_X = 9, MIN_Y = -4, MAX_Y = 4;

    void Update()
    {
        _deltaPos.x = Joystick.Horizontal * _movementSpeed.x;
        _deltaPos.y = Joystick.Vertical * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z);
    }
}
 