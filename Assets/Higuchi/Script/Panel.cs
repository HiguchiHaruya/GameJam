using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    Button _button;
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Call);
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _button.transform.localScale = new Vector2(1f, 1f);
        }
    }
    void Call()
    {
        _button.transform.localScale = new Vector2(0.5f, 0.5f);
        bool isActive = _panel == true ? true : false;
        _panel.SetActive(isActive);
    }
}
