﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAuctionRoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player");
            Application.LoadLevel("2 - AuctionRoom");
        }
    }
}
