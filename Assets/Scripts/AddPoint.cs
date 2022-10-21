using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    [SerializeField,Tooltip("�{�[���ɂ��Ă�t�^�O�̖��O")] string _tagName = default;
    [SerializeField,Tooltip("�X�R�A�ɉ��Z���鐔��")] int _addscore = default;

    /// <summary>
    /// ����ꏊ�ɓ���Ɠ��������̂������āA�X�R�A�����Z�����
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
