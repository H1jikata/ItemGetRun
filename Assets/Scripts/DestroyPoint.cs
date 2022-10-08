using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPoint : MonoBehaviour
{
    [SerializeField] string _tagName = default;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == _tagName)
        {
            Destroy(collision.gameObject);
        }
    }
}
