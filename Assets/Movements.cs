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
            Speed = 0.05f;
            transform.Translate(Speed, 0f, 0f, Space.Self);

        }

        if (Input.GetKey(KeyCode.S))
        {
            Speed = (Speed / 5);
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

      




    }
}
