using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float time;
    public bool timeonoff;
    public int PlusOne;

    


	// Use this for initialization
	void Start () {
        time = 0;
        PlusOne = 1;
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
        
        if (timeonoff == true)
        {
            time += PlusOne * Time.deltaTime;
            Debug.Log(time);
        }
        


        if (Input.GetKey(KeyCode.R))
        {
            timeonoff = false;

        }
     
        
    }


}
