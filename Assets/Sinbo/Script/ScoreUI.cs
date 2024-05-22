using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    int _scorePoint;
    public Text _scoreText;

    void Start()
    {
        _scorePoint = Select._score; //取得する
        _scoreText.text = ("Score:" + _scorePoint.ToString());
    }

    private void Update()
    {
        _scorePoint = Select._score; //取得する
        _scoreText.text = ("Score:" + _scorePoint.ToString());
    }

}
