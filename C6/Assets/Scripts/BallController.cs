using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float _STARTINGFORCE = 500f;
    bool _hasStarted = false;
    Rigidbody _rbody;
    Vector3 _startingForce = new Vector3(1, 1);

    private void Awake()
    {
        _rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_hasStarted && Input.GetButtonDown("Fire1"))
        {
            _hasStarted = true;
            _startingForce *= _STARTINGFORCE;
            _rbody.AddForce(_startingForce);
        }
    }
}
