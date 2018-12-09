using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidSculptureInteract : Interactable
{

    public bool rotating = false;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    public float rotationSpeed = 0f;
    public float y = 0f;

    void Update()
    {
        rotationSpeed = 0f;

        // A
        if (Input.GetKeyDown(KeyCode.JoystickButton8) || Input.GetKey(KeyCode.A))
        {
            Debug.Log("JoystickButton8 or A pressed");
            rotationSpeed = 100f;
        }

        // B
        if (Input.GetKeyDown(KeyCode.JoystickButton10) || Input.GetKey(KeyCode.B))
        {
            Debug.Log("JoystickButton10 or B pressed");
            rotationSpeed = -100f;
        }

        rotateDavid();
    }


    public override void StartInteraction()
    {
        Debug.Log("started");
        rotating = true;
        rotateDavid();

    }

    public override void EndInteraction()
    {
        Debug.Log("end");
        rotating = false;
    }

    public void rotateDavid()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;

            if (rotationSpeed != 0)
            {
                y += Time.deltaTime * rotationSpeed;

                if (y > 360.0f)
                    y = 0.0f;

                transform.localRotation = Quaternion.Euler(0, y, 0);
            }
        }
    }
   
}