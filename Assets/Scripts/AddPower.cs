using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour
{
    [SerializeField,Tooltip("プレイヤーのタグの名前")] string _tagName = default;
    [SerializeField,Tooltip("プレイヤーに力を加える方向")] Vector2 _powerDir = default;

    /// <summary>
    /// 範囲にはいってきたプレイヤーを飛ばす
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
