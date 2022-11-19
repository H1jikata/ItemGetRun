using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotte : MonoBehaviour
{
    [SerializeField, Tooltip("乱数の一番したと一番うえ")] float _min, _max;
    [SerializeField, Tooltip("スロットのあたり確率")] float _pMin, _pMax;
    [SerializeField] int _hitNum = default;
    [SerializeField] GameObject _reel = default;
    [SerializeField, Tooltip("スロットの数字オブジェクト")] GameObject[] _number = default;
    [SerializeField, Tooltip("数字をだす場所のObject")] GameObject[] _posi = default;

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
            for (int i = 0; i < 3; i++) // もし当たったらランダムで数字を出すように設定
            {
                Instantiate(_number[_num - 1], _posi[i].transform);
            }
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

    void Slotte()
    {
        Vector3 _currentePos = this._reel.transform.position; // 初期位置を保存
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
