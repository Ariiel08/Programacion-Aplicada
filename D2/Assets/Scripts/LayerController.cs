using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    float _scrollingSpeed = 0.1f, _currentTempSpeed;
    MeshRenderer _renderer;
    Vector2 _currentPosition = new Vector2();

    void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentTempSpeed = _scrollingSpeed * (20/gameObject.transform.position.z);
        _currentPosition.x += _currentTempSpeed * Time.deltaTime;
        _renderer.material.mainTextureOffset = _currentPosition;
    }
}
