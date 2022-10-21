using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    [SerializeField] string _tagName = default;
    [SerializeField] int _addscore = default;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == _tagName)
        {
            Add();
            Destroy(collision.gameObject);
        }
    }

    void Add()
    {
        GameManager.AddScore(_addscore);
    }
}
