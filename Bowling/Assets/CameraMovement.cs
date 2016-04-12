using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    float x;
    float y;
	// Use this for initialization
	void Start ()
    {
    
	}
	
	// Update is called once per frame
	void Update ()
    {
        x -= Input.GetAxis("Mouse Y") * 5;
        y += Input.GetAxis("Mouse X") * 5;

        x = Mathf.Clamp(x, -90, 90);
        transform.rotation = Quaternion.Euler(x, y, 0);
        //player.transform.rotation = Quaternion.Euler(0, y, 0);
    }
}
