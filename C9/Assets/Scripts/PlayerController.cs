using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject munition;
    Vector3 startingSpeed, userInput;
    const float SCALAR_SPEED = 20f;
    float currentAngle, deltaY, deltaX;

    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? Input.GetTouch(0).position : Input.mousePosition);
        deltaY =  userInput.y - gameObject.transform.position.y;
        deltaX = userInput.x - gameObject.transform.position.x;

        currentAngle = Mathf.Atan(deltaY / deltaX);

        //Trigger
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(munition, gameObject.transform.position, Quaternion.identity).GetComponent<MunitionBehaviour>().Shoot(startingSpeed, currentAngle);
        }
    }
}
