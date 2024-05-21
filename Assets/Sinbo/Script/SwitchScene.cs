using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private string loadScene;

    // Update is called once per frame
    void Update()
    {
        Scene();
    }

    public void Scene()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(loadScene);
        }
    }
}
