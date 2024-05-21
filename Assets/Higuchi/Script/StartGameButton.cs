using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    Button _Scenebt;
    [SerializeField] Image _fadeimage;
    void Start()
    {
        _Scenebt = GetComponent<Button>();
        _Scenebt.onClick.AddListener(Call);
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _Scenebt.transform.localScale = new Vector2(1f, 1f);
        }
    }
    void Call()
    {
        _Scenebt.transform.localScale = new Vector2(0.5f, 0.5f);
        StartCoroutine("FadeScene");

    }


    IEnumerator FadeScene()
    {
        float fadeDuration = 3.0f;
        float timer = 0;

        while (timer < fadeDuration)
        {
            float alpha = Mathf.Lerp(0, 1, timer / fadeDuration);

            if (_fadeimage != null)
                _fadeimage.color = new Color(0, 0, 0, alpha);
            else
                Debug.Log("イメージnull");

            timer += Time.deltaTime;
            yield return null;
        }

        if (_fadeimage != null)
            _fadeimage.enabled = false;
        else
            Debug.Log("イメージnull");

        SceneManager.LoadScene("");
    }
}
