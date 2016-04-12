using UnityEngine;
using System.Collections;

public class Bowl : MonoBehaviour {

    bool isMoving;
	// Use this for initialization
	void Start ()
    {
        isMoving = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
	   if(Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = true;

        }
        if (isMoving == true)
        {
            gameObject.transform.Translate(0.0f, 0.0f, 3.0f * Time.deltaTime * 5.0f);
        }
    }
}
