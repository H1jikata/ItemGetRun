using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotte : MonoBehaviour
{
    [SerializeField,Tooltip("乱数の一番したと一番うえ")] float _min, _max;
    [SerializeField, Tooltip("スロットのあたり確率")] float _pMin, _pMax;
    [SerializeField] int _hitNum = default;
    [SerializeField, Tooltip("スロットの数字オブジェクト")] GameObject[] _number = default;

    int _luccky = default;
    float _unLuccky = default;
    int[] _avoidNum = default; 
    void Start()
    {
        _avoidNum = new int[3];
        _luccky = (int)Random.Range(_pMin, _pMax);

        if(_hitNum == _luccky)
        {
            Debug.Log("a");
        }
        else
        {
            for (int i = 0; i < _avoidNum.Length; i++) //　一度一度数字をとめる
            {
                _unLuccky = Random.Range(_min, _max);
                _avoidNum[i] = (int)_unLuccky;
                Debug.Log(_avoidNum[i]);
            }
        }
    }
}
