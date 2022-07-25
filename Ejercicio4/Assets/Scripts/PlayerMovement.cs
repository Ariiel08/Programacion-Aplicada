using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector3 movement;
    private SpriteRenderer sr;
    private string WALK_ANIMATION = "Walking";
    private string ATTACK_ANIMATION = "Attacking";
    private string RUN_ANIMATION = "Running";
    private Animator anim;
    private float moveForce = 5f;
    private float runningForce = 8f;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        Walk();
        Attack();
        Run();
    }

    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void PlayerMoveKeyboard()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        transform.position += movement * Time.deltaTime * moveForce;
    }

    void Walk()
    {
        if (movement.x > 0 || movement.y > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movement.x < 0 || movement.y < 0)
        {
            sr.flipX = true;
            anim.SetBool(WALK_ANIMATION, true);
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    void Attack()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool(ATTACK_ANIMATION, true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool(ATTACK_ANIMATION, false);
        }

    }

    void Run()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && (movement.x != 0 || movement.y != 0))
        {
            moveForce = runningForce;
            anim.SetBool(RUN_ANIMATION, true);
        }
        if (Input.GetKey(KeyCode.LeftShift) && (movement.x != 0 || movement.y != 0))
        {
            anim.SetBool(RUN_ANIMATION, true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveForce = 5f;
            anim.SetBool(RUN_ANIMATION, false);
        }
    }
}
