using UnityEngine;
using System.Collections;

public class CopyCamera : MonoBehaviour {

	// Use this for initialization
    public GameObject GameCamera;
    void Update()
    {
        gameObject.transform.position = GameCamera.transform.position;
        gameObject.transform.rotation = GameCamera.transform.rotation;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y,0);
    }
}
