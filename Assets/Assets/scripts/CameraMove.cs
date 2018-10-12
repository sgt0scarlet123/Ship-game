using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public Transform ShipPosition;
    
    // Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(1f, 0f, 0f, Space.Self);//1, 0, 0x
        }
        transform.Translate(0f, 0f, 0f, Space.Self);//0, 1, 0y
        ShipPosition = GetComponentInChildren<Transform>();
            
	}
}
