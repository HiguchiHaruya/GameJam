using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Image _fadeimage;
    Button StartButton;
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //StartButton.transform.localScale = new Vector2(1f, 1f);
        }
    }

    private void Start()
    {
        StartButton = GetComponent<Button>();
        StartButton.onClick.AddListener(Call);
    }

    void Call()
    {
        //StartButton.transform.localScale = new Vector2(0.5f, 0.5f);
        StartCoroutine("LoadScene");
    }

    IEnumerator LoadScene()
    {
        float fadeDuration = 4.0f;
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

        SceneManager.LoadScene("Sinbo");
    }
}
