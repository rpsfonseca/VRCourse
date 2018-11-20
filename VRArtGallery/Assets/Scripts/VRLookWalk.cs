using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;

    public float toggleAngle = 30.0f;

    public float speed = 3.0f;

    public bool moveforward;
    public bool movebackward;

    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("INPUT: " + Input.inputString);

        if (vrCamera.eulerAngles.x >= 180 && vrCamera.eulerAngles.x <= (360 - toggleAngle) /* || Input.GetAxis("AxisY") > 0*/)
        {
            moveforward = true;
            movebackward = false;
        } 
        else if (vrCamera.eulerAngles.x <=180 && vrCamera.eulerAngles.x >= toggleAngle /* || Input.GetAxis("AxisY") < 0*/)
        {
            moveforward = false;
            movebackward = true;
        }
        else
        {
            moveforward = false;
            movebackward = false;
        }

        if (moveforward == true)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
        
        if (movebackward == true)
        {
            Vector3 backward = vrCamera.TransformDirection(-Vector3.forward);

            cc.SimpleMove(backward * speed);
        }

        if (InteractionManager.currentInteractable != null && Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("sdkjhfkjasdhfjkhsdajkhf");
            InteractionManager.Engage();
        }
    }
}
