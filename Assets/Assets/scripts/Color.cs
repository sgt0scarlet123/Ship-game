using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {
    public Animator Left1;
    public Animator Right1;
    public Animator Standard;
    public bool standard;
    public bool left;
    public bool right;
    public float countdown=2;
    
    // Use this for initialization
    void Start()
    {
        Standard = GetComponent<Animator>();
        Left1 = GetComponent<Animator>();
        Right1 = GetComponent<Animator>();
        standard = false;
        right = false;
        left = false;
      
    }


    // Update is called once per frame
    void Update() {
            left = false;
            right = false;

        if (Input.GetKey(KeyCode.T))
        {
            standard = true;
        }    
      if (standard == true)
        {
            Standard.Play("New Animation");
        }
      if (Input.GetKey(KeyCode.A))
        {
            countdown -= Time.deltaTime;
        }
      if (Input.GetKeyDown(KeyCode.A))
        {
            Left1.Play("Left");
        }
      if (countdown <= 0.0f)
        {
            left = true;
        }
        if (Input.GetKey(KeyCode.A) && (left == true)) 
            {

            Left1.Play("Left2");

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
            countdown = 2;
        }
      

        
       if (Input.GetKey(KeyCode.D))
        {
            countdown -= Time.deltaTime;

        }
       if (Input.GetKeyDown(KeyCode.D))
           {
            Right1.Play("Right");
           }
          if (countdown <= 0.0f)
        {
            right = true;
        }

        if (Input.GetKey(KeyCode.D) && (right == true)) 
        {
            Right1.Play("Right2");
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            countdown = 2;
            right = false;
        }

       if (Input.GetKey(KeyCode.R))
        {
            standard = false;
        }

	}

   

    

}
