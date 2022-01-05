using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public List<GameObject> wheels;

    private void Start()
    {
        // transform.DOMoveZ(2000, 200);
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, 16f * Time.deltaTime);

        foreach (var wheel in wheels)
        {
            wheel.transform.Rotate(520f * Time.deltaTime, 0, 0);
        }
    }
}