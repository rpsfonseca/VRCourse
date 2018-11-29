using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidSculptureInteract : Interactable 
{
	// private DavidInteract david;

    public float stare_time = 0f; // timer 
    public float y = 0f;
    public bool rotating = false;
    private float rotationSpeed;

    // private Vector3 davidSize;

    // public float sizeX;
    // public float sizeY;
    // public float sizeZ;

    // private float y;
    // private bool rotateY;
    
    public override void StartInteraction()
    {
        stare_time = 0f;
    }

    public override void Interaction()
    {
        stare_time = stare_time + Time.deltaTime;

        Debug.Log("Interaction!");

        if (stare_time >= 2)
        {
            Debug.Log("starting!");
            RotateDavid();
        }
    }

    public void ResetFigure()
    {
        stare_time = 0f;
        rotationSpeed = 0f;
        rotating = false;
    }

    public override void EndInteraction()
    {
        ResetFigure();
    }


    public void RotateDavid()
    {
        rotating = true;
        rotationSpeed = 20f;
        y += Time.deltaTime * rotationSpeed;

        if (y > 360.0f)
            y = 0.0f;

        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}