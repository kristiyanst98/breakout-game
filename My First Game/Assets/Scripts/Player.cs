using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rigidbody;
    float _speed = 20f;
    void Start()
    {    
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        var move = new Vector3(Input.GetAxisRaw("Horizontal"), _rigidbody.velocity.y, _rigidbody.velocity.z);
        transform.position += move * _speed * Time.deltaTime;
        //_rigidbody.MovePosition(new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 50)).x, -17, 0));  
    }
}

