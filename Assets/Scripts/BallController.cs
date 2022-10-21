using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField,Tooltip("プレイヤーについているタグの名前")] string _tagName = default;
    [SerializeField,Tooltip("ボールに加えたい力の方向")] Vector3 _power = default;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(_power);　//でてきたら力を加える
    }

    /// <summary>
    /// 接触してきたら消える
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _tagName)
        {
            Destroy(this.gameObject);
        }
    }
}
