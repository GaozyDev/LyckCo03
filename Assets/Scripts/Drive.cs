using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public List<GameObject> wheels;

    void Update()
    {
        transform.position += new Vector3(0, 0, 16f * Time.deltaTime);

        foreach (var wheel in wheels)
        {
            wheel.transform.Rotate(520f * Time.deltaTime, 0, 0);
        }
    }
}