using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{

    public Transform forward;
    public bool start;
    public Transform Left;
    public Transform Right;
    public float Speed;





    // Use this for initialization
    void Start()
    {
       bool start = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = true; 
            
        }

        if (start == true)
        {
            transform.Translate(Speed, 0f, 0f, Space.Self);
            Speed = 0.05f;

        }
        else Speed=0;


        if (Input.GetKey(KeyCode.S))
        {
            Speed = (Speed / 5f);
            transform.Translate(Speed, 0f, 0f, Space.Self);
        }
        

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(0f, -1f, 0f, Space.Self);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 2f, 0f, Space.Self);

        }

        if (Input.GetKey(KeyCode.R))
        {
            start = false;

        }
      
        



    }
}
