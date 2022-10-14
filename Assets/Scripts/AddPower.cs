using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour
{
    [SerializeField] string _tagName = default;
    [SerializeField] Vector2 _powerDir = default;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == _tagName)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(_powerDir);
        }
    }
}
