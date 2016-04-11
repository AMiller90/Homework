using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public GameObject ball;

    private int speed = 5;
	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(gameObject.CompareTag("Player1"))
        {
            //if this key is pressed..
            if (Input.GetKey(KeyCode.D))
            {//Create a vector object and set it to a new vector
                Vector3 right = new Vector3(1.0f, 0.0f, 0.0f);
                //Move the objects position with these parameters
                transform.Translate(right * speed * Time.deltaTime);
            }
            //if this key is pressed..
            if (Input.GetKey(KeyCode.A))
            {//Create a vector object and set it to a new vector
                Vector3 left = new Vector3(-1.0f, 0.0f, 0.0f);
                //Move the objects position with these parameters
                transform.Translate(left * speed * Time.deltaTime);
            }
            //if this key is pressed..
            if (Input.GetKey(KeyCode.W))
            {//Create a vector object and set it to a new vector
                Vector3 up = new Vector3(0.0f, 0.0f, 1.0f);
                //Move the objects position with these parameters
                transform.Translate(up * speed * Time.deltaTime);
            }
            //if this key is pressed..
            if (Input.GetKey(KeyCode.S))
            {//Create a vector object and set it to a new vector
                Vector3 down = new Vector3(0.0f, 0.0f, -1.0f);
                //Move the objects position with these parameters
                transform.Translate(down * speed * Time.deltaTime);
            }


        }

        if (gameObject.CompareTag("Player2"))
        {
            //if this key is pressed..
            if (Input.GetKey(KeyCode.RightArrow))
            {//Create a vector object and set it to a new vector
                Vector3 right = new Vector3(1.0f, 0.0f, 0.0f);
                //Move the objects position with these parameters
                transform.Translate(right * speed * Time.deltaTime);
            }
            //if this key is pressed..
            if (Input.GetKey(KeyCode.LeftArrow))
            {//Create a vector object and set it to a new vector
                Vector3 left = new Vector3(-1.0f, 0.0f, 0.0f);
                //Move the objects position with these parameters
                transform.Translate(left * speed * Time.deltaTime);
            }
            //if this key is pressed..
            if (Input.GetKey(KeyCode.UpArrow))
            {//Create a vector object and set it to a new vector
                Vector3 up = new Vector3(0.0f, 0.0f, 1.0f);
                //Move the objects position with these parameters
                transform.Translate(up * speed * Time.deltaTime);
            }
            //if this key is pressed..
            if (Input.GetKey(KeyCode.DownArrow))
            {//Create a vector object and set it to a new vector
                Vector3 down = new Vector3(0.0f, 0.0f, -1.0f);
                //Move the objects position with these parameters
                transform.Translate(down * speed * Time.deltaTime);
            }


        }

    }

    void OnTriggerEnter(Collider other)
    {
        Parent(gameObject, ball);
    }

    public void Parent(GameObject parentOb, GameObject childOb)
    {
        childOb.transform.SetParent(parentOb.transform);
    }
}
