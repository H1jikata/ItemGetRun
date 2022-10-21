using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    static GameManager _instance;
    static public GameManager Instance => _instance;

    [SerializeField,Tooltip("Score��UI�ɂ��Ă���Tag�̖��O")] string _tagName = default;
    [SerializeField, Tooltip("Score�̑O�ɂ���P��")] string _score = default;
    int _currentScore = default;
    bool _startTrigger = default;

    GameObject _scoreObject;
    Text _scoreText;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start()
    {
        _currentScore = 0; //�Q�[�����n�܂�����K������������
    }

    // Update is called once per frame
    void Update()
    {
        if (_startTrigger)�@//�Q�[���X�^�[�g��ɃX�R�A�𔽉f������
        {
            _scoreObject = GameObject.FindWithTag(_tagName); //Find�̏������d�����Ƃ�m���Ă��邪�A���̃Q�[���͂����܂ŏd���Ȃ�Ȃ��̂Ŋy��Find���̗p
            _scoreText = _scoreObject.GetComponent<Text>();
            _scoreText.text = _score + _currentScore;
        }
    }


    static public void AddScore(int num)
    {
        Instance._currentScore += num;
    }
    /// <summary>
    /// �f�o�b�O�p
    /// </summary>
    public void OnButtomDown()
    {
        _startTrigger = true;
    }

    void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}
