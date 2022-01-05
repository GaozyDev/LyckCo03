using System;
using DG.Tweening;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    public GameObject car;

    private bool _isZoomIn = true;

    private bool _rise = true;

    private float _time = 0;

    private void Start() {
        // 摄像机抬头
        transform.DORotate(new Vector3(8, 0, 0), 3);
    }

    void Update() {
        _time += Time.deltaTime;

        if (_isZoomIn) {
            // 摄像机拉近
            transform.position += new Vector3(0, 0, 18f * Time.deltaTime);
            
            if (car.transform.position.z - transform.position.z < 16) {
                transform.RotateAround(car.transform.position, new Vector3(0, 1, 0), -3.5f * Time.deltaTime);
            }

            if (car.transform.position.z - transform.position.z < 9) {
                _isZoomIn = false;
            }
        } else {
            transform.position += new Vector3(0, 0, 16f * Time.deltaTime);
            transform.RotateAround(car.transform.position, new Vector3(0, 1, 0), -4.5f * Time.deltaTime);
        }

        if (_rise && transform.rotation.y < -0.99f) {
            Debug.Log("DOMoveY");
            transform.DOMoveY(3f, 15).SetEase(Ease.Linear);
            _rise = false;
        }
    }
}