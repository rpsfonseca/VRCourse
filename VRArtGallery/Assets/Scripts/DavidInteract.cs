using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidInteract : Interactable 
{
    private DavidInteract david;

    private Vector3 davidSize;

    public float sizeX;
    public float sizeY;
    public float sizeZ;

    private float y;
    private bool rotateY;
    private float rotationSpeed;

    public bool rotating = false;

    public float stare_time = 0f; // timer 

    
    public override void StartInteraction()
    {
        stare_time = 0f;
        Debug.Log("StartInteraction!");
        // // david = GetComponent<David>();
        // davidSize = new Vector3(sizeY, sizeZ, sizeX);
        // david.davidData.size = davidSize;
        // transform.localScale += new Vector3(1F, 1F, 1F);
        //videoPlayer = this.transform.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    public override void Interaction()
    {
        stare_time = stare_time + Time.deltaTime;
        Debug.Log("Interaction!");


        if (!rotating && stare_time >= 2f)
        {
            Debug.Log("startuje!");
            // FixedUpdate();
        }

        // if (rotating && light.intensity > 0)
        // {
        //     light.intensity = -0.0000000001f;
        // }
    }

    public void ResetFigure()
    {
        stare_time = 0f;
        rotationSpeed = 0f;
    }

    public override void EndInteraction()
    {
        ResetFigure();
    }


    public void FixedUpdate()
    {
        rotationSpeed = 20f;
        
        y += Time.deltaTime * rotationSpeed;

        if (y > 360.0f)
            y = 0.0f;

        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}