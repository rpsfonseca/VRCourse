using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuctioneerManager : MonoBehaviour {

    // Use this for initialization

    ShredPaiting shredPainting;
    public GameObject shredder;

    AudioSource[] audio;
    private bool canBid = false;
    public bool inBidRange = false;

	void Start () {
        shredPainting = shredder.GetComponent<ShredPaiting>();
        audio = this.GetComponentsInChildren<AudioSource>();
        audio[1].enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.JoystickButton12) || Input.GetKey(KeyCode.C))
        {
            Debug.Log("C pressed");
            Debug.Log(inBidRange);
            Debug.Log(canBid);
            if (inBidRange && canBid)
            {
                audio[1].enabled = true;
                audio[1].Play();
            }  
        }

        if (audio[0].isPlaying)
        {
            canBid = false;
        }
        else
        {
            canBid = true;
        }

        if(audio[1].enabled && !audio[1].isPlaying)
        {
            shredPainting.shred = true;
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
