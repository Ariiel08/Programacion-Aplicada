using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    float _speedX = 20f;
    Vector3 _deltaPos = new Vector3();
    Vector3 _startingPosition = new Vector3(0, 0);
    const float MIN_LIM_X = -8f, MAX_LIM_X = 8f;
    public GameObject projectile;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _speedX * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
            gameObject.transform.position.y,
            gameObject.transform.position.z);

        Debug.Log(Input.GetAxis("Jump"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _startingPosition = gameObject.transform.position;
            _startingPosition.y = -2.5f;
            Instantiate(projectile, _startingPosition, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
       
    }
}
