using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField,Tooltip("スポーンさせたいボールのプレファブをいれる"),Header("アタッチ関係")] GameObject _ballPrefub = default;
    [SerializeField,Tooltip("ボールをスポーンさせるオブジェクトをいれる")] GameObject _spawnPosition = default;

    [SerializeField,Tooltip("インターバルの時間を測る"),Header("時間関係")] float _time = 0;
    [SerializeField,Tooltip("ボールをスポーンさせるインターバルのタイム")] float _timeInterval = 0.6f;

    bool _isSpawn = default;　//シーンが始まって最初にわかないよう

    private void Start()
    {
        _isSpawn = false; //ほかのところでなにかあっても大丈夫なようにfalseにする
    }
    void Update()
    {
        if(_isSpawn)
        {
            _time += Time.deltaTime;

            if (_time >= _timeInterval)　//_timeIntervalが_timeを超えるボールがスポーンし、_timeをリセットさせループさせる
            {
                Instantiate(_ballPrefub, _spawnPosition.transform);
                _time = 0;
            }
        }
    }

    public void OnButtomDown()
    {
        _isSpawn = true;
    }
}
