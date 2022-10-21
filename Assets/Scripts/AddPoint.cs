using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    [SerializeField,Tooltip("ボールについてるtタグの名前")] string _tagName = default;
    [SerializeField,Tooltip("スコアに加算する数字")] int _addscore = default;

    /// <summary>
    /// ある場所に入ると入ったものが消えて、スコアが加算される
    /// </summary>
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
