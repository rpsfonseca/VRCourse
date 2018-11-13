using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_and_Grab : MonoBehaviour {

    public float stare_time = 0f; // timer 
    public Transform VRHand;
    public Rigidbody TargetObject;
    public bool grabbed = false;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        stare_time = stare_time + Time.deltaTime;

        if (stare_time >= 2f && VRHand.childCount == 0) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            GrabObject();
        }
	}

    public void ResetStareTime()
    {
        stare_time = 0f;
    }

    public void GrabObject()
    {
        grabbed = true;
        TargetObject.transform.parent = VRHand.transform;
        TargetObject.transform.position = VRHand.transform.position + (VRHand.transform.forward * 10.0f);
        TargetObject.transform.eulerAngles = new Vector3(
             VRHand.transform.eulerAngles.x + TargetObject.transform.eulerAngles.x + 60,
             VRHand.transform.eulerAngles.y + TargetObject.transform.eulerAngles.y - 90,
             VRHand.transform.eulerAngles.z + TargetObject.transform.eulerAngles.z 
        );
    }
}
