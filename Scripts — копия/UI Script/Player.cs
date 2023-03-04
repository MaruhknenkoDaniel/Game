using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rb;
    public float _speed = 5f;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        _rb.velocity = transform.TransformDirection(new Vector3(v, 0,h)* _speed);  
    }
}
