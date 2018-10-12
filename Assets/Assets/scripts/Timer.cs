using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float Sec;
    public bool timeonoff;
    public int PlusOne;
    public int timer;
    public string Timer_Min_Sec = "zero";
    public int Min;
    public int Minutes;


    // Use this for initialization
    void Start()
    {
        Sec = 0;
        PlusOne = 1;
        timer = 0;
        Min = 0;
        Minutes = 0;
        Timer_Min_Sec = "Timer";



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            timeonoff = true;
        }






    }
    void FixedUpdate()
    {
        TimerScript();

    }











    public void TimerScript()
    {
        if (timeonoff == true)
        {
            Sec += PlusOne * Time.deltaTime;

        }
        timer = Mathf.RoundToInt(Sec);
        Minutes = Mathf.RoundToInt(Min);

        if (Input.GetKey(KeyCode.R))
        {
            timeonoff = false;

        }
        if (Sec >= 60f)
        {
            Min = Min + 1;
            Sec = 0;
        }
        Debug.LogFormat("{0},,{2},{3}:", Timer_Min_Sec, "", Minutes, timer, "");


    }



}
