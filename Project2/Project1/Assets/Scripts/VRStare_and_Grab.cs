using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_and_Grab : MonoBehaviour {

    public float stare_time = 0f; // timer 
    public Transform VRHand;
    public Rigidbody TargetObject;
    public bool grabbed = false;

    public ChargeSpear spearCode;


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
        spearCode.enabled = true;
        TargetObject.transform.parent = VRHand.transform;
        TargetObject.transform.position = VRHand.transform.position + (VRHand.transform.forward * 10.0f);
        TargetObject.transform.eulerAngles = new Vector3(
             TargetObject.transform.eulerAngles.x - 80,
             TargetObject.transform.eulerAngles.y + 194 + 45,
             TargetObject.transform.eulerAngles.z + 92
        );
        spearCode.targetPos = TargetObject.transform.position + (TargetObject.transform.forward * 100.0f);
    }
}
