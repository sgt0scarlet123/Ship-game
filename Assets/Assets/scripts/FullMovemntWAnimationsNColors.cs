using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullMovemntWAnimationsNColors : MonoBehaviour
{
   //Speed and Start/1/
    public bool start;
    public Transform forward;
    //Speed/1/
    public float Speed;
    public float SpeedRandomiser;
    public float SpeedMin;
    public float SpeedMax;

    //Turn/2/
    public float right1;
    public float left1;
    public Transform Right;
    public Transform Left;
    public bool right;
    public bool left;
    //Turn-Animations and Color/2/
    public Animator Left1;
    public Animator Right1;
    public Animator Standard;
    public bool standard;
    public float countdown;


    //Void Start Sets all Bool´s to False, Sets SpeedRandomiser value//
    void Start()
    {
        start = false;
        SpeedMin = 0.005f;
        SpeedMax = 0.05f;
        SpeedRandomiser = Random.Range(SpeedMin, SpeedMax);
        standard = false;
        right = false;
        left = false;
        left1 = -0.4f;
        right1 = 0.8f;
        countdown = 1.0f;
    }

    //void Update Sets Bool´s left And right to False every frame unless void Update calls a void Function//
    void Update()
    {
        left = false;
        right = false;

        StartNContinue();
        SpeedController();
        TurnLeft();
        TurnRight();
        StopSlashAnchor();
    }


    //void Functions//

    //void StartNContinue And Stop/Anchor Starts and Stops the game// 
    public void StartNContinue()
    {
        if (Input.GetKey(KeyCode.T))
        {
            start = true;
            standard = true;
        }
        if (standard == true & (start == true))
        {
            Standard.Play("New Animation");
            transform.Translate(Speed, 0f, 0f, Space.Self);
            Speed = SpeedRandomiser;
        }
    }
    public void StopSlashAnchor()
    {
        if (Input.GetKey(KeyCode.R))
        {
            standard = false;
            start = false;
        }
    }
  
    //void SpeedController changes ship speed if W(faster) or S(slower) is presed//
    public void SpeedController()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Speed = (Speed + Speed / 2);
            transform.Translate(Speed, 0f, 0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Speed = (Speed / 5f);
            transform.Translate(Speed, 0f, 0f, Space.Self);
        }
    }

    //void TrunLeft and TurnRight handels Left and Right turning//
    public void TurnLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            countdown -= Time.deltaTime;
            transform.Rotate(0f, left1, 0f, Space.Self);
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
                countdown = 1.5f;
            }    

            



        
        
    }
    public void TurnRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            countdown -= Time.deltaTime;
            transform.Rotate(0f, right1, 0f, Space.Self);
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
            countdown = 1.5f;
            right = false;
        }
    }
}















