using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour
{
    [SerializeField,Tooltip("�v���C���[�̃^�O�̖��O")] string _tagName = default;
    [SerializeField,Tooltip("�v���C���[�ɗ͂����������")] Vector2 _powerDir = default;

    /// <summary>
    /// �͈͂ɂ͂����Ă����v���C���[���΂�
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == _tagName)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(_powerDir);
        }
    }
}
