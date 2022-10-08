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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _tagName)
        {
            Destroy(this.gameObject);
        }
    }
}
