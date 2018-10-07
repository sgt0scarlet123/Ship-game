using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {
    public Animator Left;
    public Animator Right;
    public Animator Standard;
    public bool standard;
    public bool left;
    public bool right;
    public float countdown= 10.0f;
    // Use this for initialization
    void Start()
    {
        Standard = GetComponent<Animator>();
        Left = GetComponent<Animator>();
        Right = GetComponent<Animator>();
        standard = false;
        right = false;
        left = false;
        countdown = 10.0f;
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
      if (Input.GetKeyDown(KeyCode.A))
        {
            Left.Play("Left");
            
            
            {while (countdown > 0.0f) ;
                countdown -= (Time.deltaTime);
            }
        }
      if (countdown <= 0.0f)
        {
            left = true;
            countdown = 10.0f;
        }

        if (Input.GetKey(KeyCode.A)&(left = true)) 
        {
            
            Left.Play("Left2");
        }
       if (Input.GetKey(KeyCode.D))
        {
            right = true;

        }
       if (right == true)
        {
            Right.Play("Right");
        }
       if (Input.GetKey(KeyCode.R))
        {
            standard = false;
        }

	}

   

    

}
