using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator currentAnimator;
    float maxRunningSpeed = 15f, maxWalkingSpeed = 8f, currentSpeed;
    Vector3 _deltaPos = new Vector3();
    SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Awake()
    {
        currentAnimator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentAnimator.SetBool("isAttacking", true);

        }else if (Input.GetButtonUp("Fire1")) 
        {
            currentAnimator.SetBool("isAttacking", false);

        }

        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxRunningSpeed : maxWalkingSpeed);
        _deltaPos.x = currentSpeed * Time.deltaTime;
        currentAnimator.SetFloat("Speed", Mathf.Abs(currentSpeed));

        _renderer.flipX = currentSpeed < 0;

        gameObject.transform.Translate(_deltaPos);
    }
}
