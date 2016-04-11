using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    Movement move;
    bool isMoving;
    public GameObject ball;

	// Use this for initialization
	void Start ()
    {
        isMoving = false;
        gameObject.GetComponent<GameObject>();
        move = GetComponent<Movement>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        //if this key is pressed..
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ball.transform.IsChildOf(gameObject.transform))
            {
                isMoving = true;
                
            }

        }
        if (isMoving == true)
        {
            if (gameObject.CompareTag("Player1"))
            {
                ball.transform.Translate(3.0f * Time.deltaTime * 5.0f, 0.0f, 0.0f);
            }
                

            if(gameObject.CompareTag("Player2"))
            {
              ball.transform.Translate(-3.0f * Time.deltaTime * 5.0f, 0.0f, 0.0f);
            }
        }



    }


    void OnTriggerEnter(Collider other)
    {

        isMoving = false;

        if(gameObject.CompareTag("Player1"))
        {
            if(other.gameObject.CompareTag("Player2"))
            {
                Destroy(other.gameObject);
                Destroy(ball);
            }
            else
            {
                move.Parent(other.gameObject, ball);
                ball.transform.Translate(0.0f, 0.0f, -3.0f * Time.deltaTime * 5.0f);
            }
        }

        if (gameObject.CompareTag("Player2"))
        {
            if(other.gameObject.CompareTag("Player1"))
            {
                Destroy(other.gameObject);
                Destroy(ball);
            }
            else
            {
                move.Parent(other.gameObject, ball);
                ball.transform.Translate(0.0f, 0.0f, -3.0f * Time.deltaTime * 5.0f);
            }
        }
   
    }
}
