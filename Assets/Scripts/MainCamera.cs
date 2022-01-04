using UnityEngine;

public class MainCamera : MonoBehaviour {
    
    public GameObject car;

    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(0, 0, 16f * Time.deltaTime);
        transform.RotateAround(car.transform.position, new Vector3(0, 1, 0), 20f * Time.deltaTime);
    }
}