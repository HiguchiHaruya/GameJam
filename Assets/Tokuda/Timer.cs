using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Image _fadeimage;
    public static float _time = 40;
    [SerializeField] Text _txt;
    private void Update()
    {
        Debug.Log(_time);

        if (_time >= 0)
        {
            _time -= Time.deltaTime;
            _txt.text = ($"Time : {(int)_time}");
        }

        if ((int)_time == 0)
        {
            StartCoroutine("LoadResult");
        }
    }
    IEnumerator LoadResult()
    {
        float fadeDuration = 3.0f;
        float timer = 0;

        _fadeimage.raycastTarget = true;

        while (timer < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, timer / fadeDuration);

            if (_fadeimage != null)
                _fadeimage.color = new Color(1, 1, 1, alpha);
            else
                Debug.Log("イメージnull");

            timer += Time.deltaTime;
            yield return null;
        }

        //if (_fadeimage != null)
        //    _fadeimage.enabled = false;
        //else
        Debug.Log("イメージnull");
        _time = 40;
        SceneManager.LoadScene("Sinbo_Result");
    }
}
