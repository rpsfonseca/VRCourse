using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBidDetector : MonoBehaviour {

    AuctioneerManager manager;

    public GameObject canvas;

	// Use this for initialization
	void Start () {
        manager = this.GetComponentInParent<AuctioneerManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.inBidRange = true;
            canvas.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.inBidRange = false;
            canvas.SetActive(false);

        }
    }
}
