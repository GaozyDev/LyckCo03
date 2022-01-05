using System;
using DG.Tweening;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject car;

    private bool _isZoomIn = true;

    private float _time = 0;
    
    private void Start()
    {
        transform.DOMoveY(1.33f, 2).SetEase(Ease.Linear);
        
        transform.DOMoveZ(92, 5).SetEase(Ease.Linear).onComplete += () =>
        {
            _isZoomIn = false; 
            transform.DOMoveY(3.1f, 3).SetEase(Ease.Linear).onComplete += () =>
            {
                
            };
        };
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (!_isZoomIn)
        {
            transform.position += new Vector3(0, 0, 16f * Time.deltaTime);
            transform.RotateAround(car.transform.position, new Vector3(0, 1, 0), -20f * Time.deltaTime);
        }
    }
}