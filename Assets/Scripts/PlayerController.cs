using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField,Tooltip("プレイヤーのスピード")] int _speed = 5;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float _h = Input.GetAxisRaw("Horizontal");　//横だけしか動かさせたくないので、Horizontalのみ
        _rb.velocity = new Vector2(_h * _speed, _rb.velocity.y);
    }
}
