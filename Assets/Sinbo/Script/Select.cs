using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Select : MonoBehaviour
{
    //inspector����{�^�����A�T�C�����Ă�������
    public GameObject _kakigori;
    public GameObject _kashiwamoti;
    public GameObject _ramune;
    public GameObject _suika;

    //inspector����ӂ��o���ɕ\�������摜���A�T�C�����Ă�������
    public GameObject _imgKakigori;
    public GameObject _imgKashiwamoti;
    public GameObject _imgRamune;
    public GameObject _imgSuika;

    //inspector����RandomDisplay�X�N���v�g���A�^�b�`����GameObject���A�^�b�`���Ă�������
    public RandomDisplay _randomDisplay;

    public float _interval = 5.0f; //�摜��؂�ւ���܂ł̕b��

    public bool _input;

    //SE�֘A
    public AudioClip _okSe;
    public AudioClip _ngSe;
    AudioSource audioSource;

    public static int _score;

    private void Start()
    {
        _score = 0; //�X�R�A��������
        audioSource = GetComponent<AudioSource>();�@//Component���擾
        _input = false;
    }

    //��莞�Ԍ�ɉ摜��ύX����R���[�`��
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

    //��������I�񂾎��ɌĂяo����郁�\�b�h
    public void SelectKakigori()
    {
        _input = true;
        if (_imgKakigori.activeInHierarchy) 
        {
            StartCoroutine("ResetImage");
            _score += 100; //�X�R�A�𑫂�
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
            _score += 100; //�X�R�A�𑫂�
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
            _score += 100; //�X�R�A�𑫂�
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
            _score += 100; //�X�R�A�𑫂�
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
