using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidSculptureInteract : Interactable
{
    public float rotationSpeed = 0f;
    public float y = 0f;

    public float scale = 0f;
    public float scaleDiff = 0f;

    public Vector3 newScale;

    public bool interacting = false;

    void Update()
    {
        rotationSpeed = 0f;
        scaleDiff = 0f;

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

        // C
        if (Input.GetKeyDown(KeyCode.JoystickButton7) || Input.GetKey(KeyCode.C))
        {
            Debug.Log("C pressed");
            scaleDiff = 0.1f;
        }

        // D
        if (Input.GetKeyDown(KeyCode.JoystickButton14) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("D pressed");
            scaleDiff = -0.1f;
        }

        if (interacting)
        {
            rotateDavid();
            scaleDavid();
        }
    }


    public override void StartInteraction()
    {
        Debug.Log("started");
        interacting = true;
    }

    public override void EndInteraction()
    {
        Debug.Log("end");
        interacting = false;
    }

    public void rotateDavid()
    {

        if (rotationSpeed != 0)
        {
            y += Time.deltaTime * rotationSpeed;

            if (y > 360.0f)
                y = 0.0f;

            transform.localRotation = Quaternion.Euler(0, y, 0);
        }
    }

    public void scaleDavid()
    {
        if (scaleDiff != 0)
        {
            scale += Time.deltaTime * scaleDiff;

            if (scale > 1.0f)
            {
                scale = 1.0f;
                scaleDiff = scaleDiff * -1.0f;
            }

            if (scale < 0.5f)
            {
                scale = 0.5f;
                scaleDiff = scaleDiff * -1.0f;
            }

            transform.localScale = new Vector3(scale, scale, scale);
        }
    }

}