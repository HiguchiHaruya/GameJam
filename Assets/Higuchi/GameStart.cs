using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    float _time = 5;
    private void Update()
    {
        _time -= Time.deltaTime;
        Debug.Log(_time);
        if(_time <= 0)
        {
            //fadeout‚ÌƒR[ƒh“\‚é
        }
    }
}
