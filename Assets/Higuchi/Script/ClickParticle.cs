using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem _ClickEffect;
    [SerializeField] private Camera _camera;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
            _ClickEffect.transform.position = pos;
            _ClickEffect.Play();
        }
    }
}
