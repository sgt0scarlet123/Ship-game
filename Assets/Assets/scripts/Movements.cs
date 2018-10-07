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
    public bool left;
    public bool right;
    public float left1;
    public float right1;
    public float SpeedRandomiser;
    // Use this for initialization
    void Start()
    {
        start = false;
        SpeedRandomiser = Random.Range(0.05f, 0.075f);

    }

    // Update is called once per frame
    void Update()
    {

        left = false;
        right = false;

        if (Input.GetKeyDown(KeyCode.T))
        {
            start = true; 
            
        }

        if (start == true)
        {
            transform.Translate(Speed, 0f, 0f, Space.Self);
            Speed = SpeedRandomiser;

        }
        else Speed=0;

        if (Input.GetKey(KeyCode.W))
        {
            Speed = (Speed + Speed /2);
            transform.Translate(Speed, 0f, 0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Speed = (Speed / 5f);
            transform.Translate(Speed, 0f, 0f, Space.Self);
        }


        if (Input.GetKey(KeyCode.A))
        {
            left = true;

        }
        if (left == true) {

            transform.Rotate (0f, left1, 0f, Space.Self); 
        }
        

        

        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        if (right == true)
        {
            transform.Rotate(0f, right1, 0f, Space.Self);
        }
       


        if (Input.GetKey(KeyCode.R))
        {
            start = false;
        }

      
        



    }
}
