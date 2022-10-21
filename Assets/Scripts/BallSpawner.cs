using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject _ballPrefub = default;
    [SerializeField] GameObject _spawnPosition = default;

    [SerializeField] float _time = 0;
    [SerializeField] float _timeInterval = 0.6f;

    bool _isSpawn = default;
    void Update()
    {
        if(_isSpawn)
        {
            _time += Time.deltaTime;

            if (_time >= _timeInterval)
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
