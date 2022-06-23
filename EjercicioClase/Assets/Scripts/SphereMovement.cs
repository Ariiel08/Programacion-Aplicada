using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    Vector3 _deltaPos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = GameManager._movementSpeed.x * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
    }
}
