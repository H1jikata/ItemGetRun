using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField,Tooltip("�X�|�[�����������{�[���̃v���t�@�u�������"),Header("�A�^�b�`�֌W")] GameObject _ballPrefub = default;
    [SerializeField,Tooltip("�{�[�����X�|�[��������I�u�W�F�N�g�������")] GameObject _spawnPosition = default;

    [SerializeField,Tooltip("�C���^�[�o���̎��Ԃ𑪂�"),Header("���Ԋ֌W")] float _time = 0;
    [SerializeField,Tooltip("�{�[�����X�|�[��������C���^�[�o���̃^�C��")] float _timeInterval = 0.6f;

    bool _isSpawn = default;�@//�V�[�����n�܂��čŏ��ɂ킩�Ȃ��悤

    private void Start()
    {
        _isSpawn = false; //�ق��̂Ƃ���łȂɂ������Ă����v�Ȃ悤��false�ɂ���
    }
    void Update()
    {
        if(_isSpawn)
        {
            _time += Time.deltaTime;

            if (_time >= _timeInterval)�@//_timeInterval��_time�𒴂���{�[�����X�|�[�����A_time�����Z�b�g�������[�v������
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
