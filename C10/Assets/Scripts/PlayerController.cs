using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shield;
    const float shieldDistance = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(shield, gameObject.transform.position, Quaternion.identity).GetComponent<ShieldBehaviour>().Shoot(gameObject, shieldDistance);
        }
    }
}
