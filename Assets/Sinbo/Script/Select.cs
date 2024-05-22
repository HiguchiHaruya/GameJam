using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
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

    //SE関連
    public AudioClip _okSe;
    public AudioClip _ngSe;
    AudioSource audioSource;

    public static int _score;

    //スライダー
    public int _comboMax = 15; //最大値
    int _combo;
    public Slider _comboSlider;

    public GameObject _timePlus;

    public static bool _ng;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private List <Sprite> newSprite;
    private int _turn;

    private void Start()
    {
        _score = 0; //スコアを初期化
        _combo = 0; //comboを初期化
        _comboSlider.value = 0; //スライダーを初期化
        audioSource = GetComponent<AudioSource>();　//Componentを取得
    }

    //タイムを増やす関連の処理
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
    public void SelectKakigori()
    {
        if (_imgKakigori.activeInHierarchy) 
        {
            _randomDisplay.ObjNonDisplay();
            _score += 100; //スコアを足す
            _combo += 1;
            _comboSlider.value = (float)_combo;
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            _randomDisplay.ObjNonDisplay();
            spriteRenderer = GameObject.FindGameObjectsWithTag("client_remove")[_turn].GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[_turn % 4];
            audioSource.PlayOneShot(_ngSe);
        }
        
        _turn++;
    }

    public void SelectKashiwamoti()
    {
        if (_imgKashiwamoti.activeInHierarchy)
        {
            _randomDisplay.ObjNonDisplay();
            _score += 100; //スコアを足す
            _combo += 1;
            _comboSlider.value = (float)_combo;
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            audioSource.PlayOneShot(_ngSe);
            spriteRenderer = GameObject.FindGameObjectsWithTag("client_remove")[_turn].GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[_turn % 4];
            _randomDisplay.ObjNonDisplay();
        }

        _turn++;
    }
    public void SelectRamune()
    {
        if (_imgRamune.activeInHierarchy)
        {
            _randomDisplay.ObjNonDisplay(); 
            _score += 100; //スコアを足す
            _combo += 1;
            _comboSlider.value = (float)_combo;
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            audioSource.PlayOneShot(_ngSe);
            spriteRenderer = GameObject.FindGameObjectsWithTag("client_remove")[_turn].GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[_turn % 4];
            _randomDisplay.ObjNonDisplay();
        }

        _turn++;
    }
    public void SelectSuika()
    {
        if (_imgSuika.activeInHierarchy)
        {
            _randomDisplay.ObjNonDisplay();
            _score += 100; //スコアを足す
            _combo += 1;
            _comboSlider.value = (float)_combo;
            audioSource.PlayOneShot(_okSe);
            //Debug.Log(_score);
        }
        else
        {
            audioSource.PlayOneShot(_ngSe);
            spriteRenderer = GameObject.FindGameObjectsWithTag("client_remove")[_turn].GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[_turn % 4];
            _randomDisplay.ObjNonDisplay();
        }

        _turn++;
    }

}
