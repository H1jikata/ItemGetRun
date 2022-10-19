using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField,Tooltip("ScoreのUIについているTagの名前")] string _tagName = default;
    [SerializeField, Tooltip("Scoreの前につける単語")] string _score = default;
    int _currentScore = default;
    bool _startTrigger = default;

    GameObject _scoreObject;
    Text _scoreText;
    void Start()
    {
        _currentScore = 0; //ゲームが始まったら必ず初期化する
    }

    // Update is called once per frame
    void Update()
    {
        if (_startTrigger)　//ゲームスタート後にスコアを反映させる
        {
            _scoreObject = GameObject.FindWithTag(_tagName); //Findの処理が重いことを知っているが、このゲームはそこまで重くならないので楽なFindを採用
            _scoreText = _scoreObject.GetComponent<Text>();
            _scoreText.text = _score + _currentScore;
        }
    }

    /// <summary>
    /// デバッグ用
    /// </summary>
    public void OnButtomDown()
    {
        _startTrigger = true;
    }
}
