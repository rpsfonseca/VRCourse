using System.Collections;
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
    public static event InteractionEvent onEngage;
    public static event InteractionEvent onEngaging;
    public static event InteractionEvent onDisengage;

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
        		
	}
}
