using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeSpear : MonoBehaviour
{
    public VRStare_and_Grab grabCode;

    public AttackTrigger triggerSpearThrow;

    public Transform vrHand;
    public Vector3 targetPos;
    public bool goingBackwards = false;
    public HealthController health;

	// Use this for initialization
	void Start ()
    {
        triggerSpearThrow = FindObjectOfType<AttackTrigger>();
        health = FindObjectOfType<HealthController>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //vrHand = grabCode.VRHand;
        if (grabCode && grabCode.grabbed && triggerSpearThrow && triggerSpearThrow.spearThrow && health.health > 0)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 4.5f);

            if (Vector3.Distance(transform.position, targetPos) >= 0.0f && Vector3.Distance(transform.position, targetPos) < 1.0f)
            {
                if (!goingBackwards)
                {
                    goingBackwards = true;
                    targetPos = vrHand.transform.position + (vrHand.transform.forward * 10.0f);
                }
                else
                {
                    goingBackwards = false;
                    targetPos = transform.position + (transform.forward * 10.0f);
                }
            }
        }
        if (grabCode && grabCode.grabbed && triggerSpearThrow && (triggerSpearThrow.spearThrow == false))
        {
            goingBackwards = true;
            targetPos = vrHand.transform.position + (vrHand.transform.forward * 10.0f);
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 4.5f);
        } 

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "WarFireDragon")
        {
            goingBackwards = true;
            targetPos = vrHand.transform.position + (vrHand.transform.forward * 10.0f);
        }
    }
}
