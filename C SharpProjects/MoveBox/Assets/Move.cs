using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    //Create a Destination variable
    Vector3 Destination = new Vector3(4, 4, 4);
    //Variable to determine movement
    bool isMoving;
    //Public variable for speed of object movement
    public float speed;

    // Use this for initialization
    void Start()
    {//set isMoving variable to false
        isMoving = false;
        //Set starting position of gameObject
        gameObject.transform.position = new Vector3(0, 0.5f, 0);
        
    }

    void move(Vector3 stop)
    {//Moves gameobjects position to the new position passed in 
        gameObject.transform.position = new Vector3(stop.x, stop.y, stop.z);
    }

    //Function created to move object 
    Vector3 MyOwnLerp(Vector3 start, Vector3 end, float percent)
    {//Add the 2 vectors then multiply times percentage between vectors and then times delta time then times the speed variable
        return start + end * 0.05f * Time.deltaTime * speed;


    }

    

	// Update is called once per frame
	void Update ()
    {//When SpaceBar is pressed down do this 
        if (Input.GetKeyDown(KeyCode.Space))
        {//set isMoving variable to true
            isMoving = true;
        }

       //if isMoving is equal to true
        if (isMoving == true)
        {//Call Lerp Function and store its return value in new Vector3 Moving variable
            Vector3 Moving = MyOwnLerp(gameObject.transform.position, Destination, 0.5f);
            //call move function
            move(Moving);
            //Check if gameobjects position is the same as the destinations  position
            if (gameObject.transform.position.x >= Destination.x && 
                gameObject.transform.position.y >= Destination.y && 
                gameObject.transform.position.z >= Destination.z) 
            {//If true then set isMoving to false and the object will stop moving
             isMoving = false;
             
            }

        }



    }

}
