using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Find : MonoBehaviour {

    public List<Transform> children = new List<Transform>();

	// Use this for initialization
	void Start ()
    {
        //Find the gameobject named "doit" and store in a parent variable
        GameObject parent = GameObject.Find("doit");

        //loop through the parents children and for each transform found
        foreach (Transform c in parent.transform)
        {
            //store that transform in the list
            children.Add(c);
        }

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
