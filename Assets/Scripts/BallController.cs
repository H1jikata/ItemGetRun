using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] string _tagName = default;
    [SerializeField] Vector3 _power = default;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(_power);
    }

    private void Update()
    {
        
    }
}
