using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    float leftConstrain = Screen.width*2;
    float rightConstranit = Screen.width*2;
    float bottomConstraint = Screen.height*2;
    float topConstranint = Screen.height*2;
    float buffer = 1.0f;
    Camera cam;

   
    private void Start()
    {
        cam = Camera.main;
        
        leftConstrain = cam.ScreenToWorldPoint(new Vector3(-Screen.width,0.0f,0.0f )).x;
        rightConstranit = cam.ScreenToWorldPoint(new Vector3(Screen.width*2, 0.0f, 0.0f)).x;
        bottomConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height/4, 0.0f)).y;
        topConstranint = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height*3, 0.0f)).y;
    }
    private void FixedUpdate()
    {
        if (transform.position.x < leftConstrain - buffer)
        {
            transform.position = new Vector3(rightConstranit - 0.10f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rightConstranit + buffer)
        {
            transform.position = new Vector3(leftConstrain, transform.position.y, transform.position.z);
        }
        if (transform.position.y < bottomConstraint - buffer)
        {
            transform.position = new Vector3(transform.position.x, topConstranint + buffer, transform.position.z);
        }
        if (transform.position.y > topConstranint + buffer)
        {
            transform.position = new Vector3(transform.position.x, bottomConstraint - buffer, transform.position.z);
        }       

    }







}


