using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        InteractionManager.onEngage += StartInteraction;
        InteractionManager.onEngaging += Interaction;
        InteractionManager.onDisengage += EndInteraction;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void StartInteraction()
    {

    }

    public void Interaction()
    {

    }

    public void EndInteraction()
    {

    }
}
