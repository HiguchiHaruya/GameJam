using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class SliderTest : MonoBehaviour
{

    //スライダー
    public int _comboMax = 30; //最大値
    int _combo;
    public Slider _comboSlider;

    public GameObject _timePlus;


    private void Start()
    {
        _combo = 0; //comboを初期化
        _comboSlider.value = 0; //スライダーを初期化
    }

    public void Update()
    {
        ComboMax();
    }

    public void ComboMax()
    {
        if (_comboMax == _combo)
        {
            Timer._time += 5;
            _combo = 0;
            _comboSlider.value = (float)_combo;
            _timePlus.SetActive(true);
            Invoke("Delete", 1);
        }

    }

    public void Delete()
    {
        _timePlus.SetActive(false);
    }

    //風物詩を選んだ時に呼び出されるメソッド
    public void Slider()
    {
            _combo += 1;
            _comboSlider.value = (float)_combo;
            //Debug.Log(_score);
    }

}

