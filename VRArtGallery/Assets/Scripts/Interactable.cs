using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public InteractionManager.InteractionType interactionType;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public virtual void StartInteraction()
    {

    }

    public virtual void Interaction()
    {

    }

    public virtual void EndInteraction()
    {

    }
}
