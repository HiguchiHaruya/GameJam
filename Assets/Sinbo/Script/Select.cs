using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Select : MonoBehaviour
{
    //inspectorからボタンをアサインしてください
    public GameObject _kakigori;
    public GameObject _kashiwamoti;
    public GameObject _ramune;
    public GameObject _suika;

    //inspectorからふき出しに表示される画像をアサインしてください
    public GameObject _imgKakigori;
    public GameObject _imgKashiwamoti;
    public GameObject _imgRamune;
    public GameObject _imgSuika;

    //inspectorからRandomDisplayスクリプトをアタッチしたGameObjectをアタッチしてください
    public RandomDisplay _randomDisplay;

    public float _interval = 5.0f; //画像を切り替えるまでの秒数

    public bool _input;

    //SE関連
    public AudioClip _okSe;
    public AudioClip _ngSe;
    AudioSource audioSource;

    public static int _score;

    private void Start()
    {
        _score = 0; //スコアを初期化
        audioSource = GetComponent<AudioSource>();　//Componentを取得
        _input = false;
    }

    //一定時間後に画像を変更するコルーチン
    IEnumerator ResetImage()
    {
        yield return new WaitForSeconds(_interval);
        _randomDisplay.ObjNonDisplay();
        _input = false;
    }

  
    public void Update()
    {
        CheckInput();
    }

    public void CheckInput()
    {
        if (_input == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    //風物詩を選んだ時に呼び出されるメソッド
    public void SelectKakigori()
    {
        _input = true;
        if (_imgKakigori.activeInHierarchy) 
        {
            StartCoroutine("ResetImage");
            _score += 100; //スコアを足す
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            StartCoroutine("ResetImage");
            audioSource.PlayOneShot(_ngSe);
        }
    }

    public void SelectKashiwamoti()
    {
        _input = true;
        if (_imgKashiwamoti.activeInHierarchy)
        {
            StartCoroutine("ResetImage");
            _score += 100; //スコアを足す
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            audioSource.PlayOneShot(_ngSe);
            StartCoroutine("ResetImage");
        }
    }
    public void SelectRamune()
    {
        _input = true;
        if (_imgRamune.activeInHierarchy)
        {
            StartCoroutine("ResetImage"); 
            _score += 100; //スコアを足す
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            audioSource.PlayOneShot(_ngSe);
            StartCoroutine("ResetImage");
        }
    }
    public void SelectSuika()
    {
        _input = true;
        if (_imgSuika.activeInHierarchy)
        {
            StartCoroutine("ResetImage");
            _score += 100; //スコアを足す
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            audioSource.PlayOneShot(_ngSe);
            StartCoroutine("ResetImage");
        }
    }

}
