using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuctioneerManager : MonoBehaviour {

    // Use this for initialization

    AudioSource[] audio;
    private bool canBid = false;

	void Start () {
        audio = this.GetComponentsInChildren<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (!audio[0].isPlaying)
        {
            canBid = false;
        }

	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio[0].Play();
        }
    }
}
