using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int _speed = 5;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float _h = Input.GetAxisRaw("Horizontal");
        //float _v = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector2(_h * _speed, _rb.velocity.y);
    }
}
