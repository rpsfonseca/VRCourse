﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    #region Singleton
    private static InteractionManager _instance;
    public static InteractionManager Instance
    {
        get { return _instance; }
    }
    #endregion

    public delegate void InteractionEvent();

    // Event called to setup anything we need for the interaction
    public static event InteractionEvent onEngage;
    // Event called to run the code used in the interaction
    public static event InteractionEvent onEngaging;
    // Event called when we want to stop the interaction
    public static event InteractionEvent onDisengage;

    public static Interactable currentInteractable;

    void Awake()
    {
        _instance = this;
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*
         * If a button is pressed, we want to interact
         * Then call onEngage
         * Then call onEngaging
         * 
         * Once we press the same button, we want to stop interacting and be able to walk
         * Then call onDisengage
         * Then call RemoveCurrentInteractable
         */
	}

    public static void SetCurrentInteractable(Interactable interactable)
    {
        currentInteractable = interactable;
        onEngage += currentInteractable.StartInteraction;
        onEngaging += currentInteractable.Interaction;
        onDisengage += currentInteractable.EndInteraction;
    }

    public static void RemoveCurrentInteractable()
    {
        currentInteractable = null;
        onEngage = null;
        onEngaging = null;
        onDisengage = null;
    }
}