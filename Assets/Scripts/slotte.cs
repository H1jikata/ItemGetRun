using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotte : MonoBehaviour
{
    [SerializeField, Tooltip("�����̈�Ԃ����ƈ�Ԃ���")] float _min, _max;
    [SerializeField, Tooltip("�X���b�g�̂�����m��")] float _pMin, _pMax;
    [SerializeField] int _hitNum = default;
    [SerializeField] GameObject _reel = default;
    [SerializeField, Tooltip("�X���b�g�̐����I�u�W�F�N�g")] GameObject[] _number = default;
    [SerializeField, Tooltip("�����������ꏊ��Object")] GameObject[] _posi = default;

    int _luccky = default;
    float _unLuccky = default;
    int[] _avoidNum = default;
    void Start()
    {
        _avoidNum = new int[3];
        _luccky = (int)Random.Range(_pMin, _pMax);

        if (_hitNum == _luccky)
        {
            int _num = (int)Random.Range(1, 9);
            for (int i = 0; i < 3; i++) // �������������烉���_���Ő������o���悤�ɐݒ�
            {
                Instantiate(_number[_num - 1], _posi[i].transform);
            }
        }
        else
        {
            for (int i = 0; i < _avoidNum.Length; i++) //�@��x��x�������Ƃ߂�
            {
                _unLuccky = Random.Range(_min, _max);
                _avoidNum[i] = (int)_unLuccky;
                Debug.Log(_avoidNum[i]);
            }
        }
    }

    void Slotte()
    {
        Vector3 _currentePos = this._reel.transform.position; // �����ʒu��ۑ�
    }

    public enum SlotteNum
    {
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine
    }

}
