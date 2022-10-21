using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField,Tooltip("�v���C���[�̃X�s�[�h")] int _speed = 5;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float _h = Input.GetAxisRaw("Horizontal");�@//�����������������������Ȃ��̂ŁAHorizontal�̂�
        _rb.velocity = new Vector2(_h * _speed, _rb.velocity.y);
    }
}
