using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuctioneerManager : MonoBehaviour {

    // Use this for initialization

    AudioSource[] audio;

	void Start () {
        audio = this.GetComponentsInChildren<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio[0].Play();
        }
    }
}
