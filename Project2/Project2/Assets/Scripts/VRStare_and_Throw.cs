using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_and_Throw : MonoBehaviour
{

    public float stare_time = 0f; // timer 
    public Transform VRHand;
    public Rigidbody Spear;
    public Rigidbody TargetObject;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        stare_time = stare_time + Time.deltaTime;

        if (stare_time >= 2f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            ThrowSpear();
        }
    }

    public void ResetStareTime()
    {
        stare_time = 0f;
    }

    public void ThrowSpear()
    {
        Spear.isKinematic = false;
        Spear.transform.parent = null;
        Spear.AddForce(VRHand.forward * 10.0f);
    }
}
