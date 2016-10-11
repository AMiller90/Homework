using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawHalfCircle : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        List<GameObject> halfverts = new List<GameObject>();

        int np = 10;

        halfverts = HalfCircle(np, 5);

        DrawSphere(np, 10, ref halfverts);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public List<GameObject> HalfCircle(int np, int radius)
    {
        List<GameObject> spherelist = new List<GameObject>();

        int pieces = np - 1;

        for (int i = 0; i < np; i++)
        {
            //Angle between each index
            float theta = Mathf.PI * i / pieces;
            //get the cos of the angle and multiply by the radius
            float X = Mathf.Cos(theta) * radius;
            //get the sin of the angle and multiply by the radius
            float Y = Mathf.Sin(theta) * radius;

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(X, Y, 0);
            sphere.transform.SetParent(gameObject.transform);
            spherelist.Add(sphere);
        }

        return spherelist;
    }

    public void DrawSphere(int np, int numMeridians, ref List<GameObject> halfSphere)
    {
        //Set up a counter to start at that index of the vertices array so we can set the 
        //respective vertex with meridian points
        int counter = 0;

        //Loop through meridians
        for (int i = 0; i < numMeridians; i++)
        {//Get the angle
            float phi = 2 * Mathf.PI * ((float)i / (float)(numMeridians));
            //Loop through the number of points and increase the counter each time
            for (int j = 0; j < np; j++, counter++)
            {//Create X variable for the current x position of newVerts
                float X = halfSphere[j].transform.position.x;
                //Create Y variable for the current y position of newVerts * cos(phi) - the current z position of newVerts * sin(phi)
                float Y = halfSphere[j].transform.position.y * Mathf.Cos(phi) - halfSphere[j].transform.position.z * Mathf.Sin(phi);
                //Create Z variable for the current z position of newVerts * cos(phi) + the current y position of newVerts * sin(phi)
                float Z = halfSphere[j].transform.position.z * Mathf.Cos(phi) + halfSphere[j].transform.position.y * Mathf.Sin(phi);

                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.GetComponent<MeshRenderer>().material.color = Color.black;
                sphere.transform.SetParent(gameObject.transform);
                sphere.transform.position = new Vector3(X, Y, Z);
            }
        }
    }
}

