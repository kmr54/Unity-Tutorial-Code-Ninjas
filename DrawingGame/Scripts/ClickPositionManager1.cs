using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//no start method needed

/*
this script is attached to ClickDetector and handles user input for spawning objects

Note:
screen space = device screen
world space = Unity Application screen
*/

// Update is called once per frame

public class ClickPositionManager1 : MonoBehaviour
{

    public Vector3 clickPosition;
    public GameObject myPrefab; //object we will be working with
    public float distance = 3f; //make public so can edit in Unity
    public float distanceChange = 1f; //

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButton(1))
        //if left button clicked or right button is dragged, do the following:
        {
            distance += distanceChange;
            /*
             *Goal: Store and display current position as vector
             */
            clickPosition = -Vector3.one;
            //equalivatent of Vector3 clickPosition =  new Vector3(1f,1f,1f);
            //did this to know if something is wrong

            clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0f,0f,distance) );
            //screenToWorldPoint converts mouse position in screen space to that in wordl space

            Debug.Log(clickPosition);

             //create new sphere at the position you clicked
            //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //sphere.transform.position = clickPosition;
 
            Instantiate(myPrefab, clickPosition, Quaternion.identity);

            ///quaternion is for rotation of vectors
            ///.identity is 0 rotation
             


     
        }
    }
}
