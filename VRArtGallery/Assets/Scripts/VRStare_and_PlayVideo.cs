using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_and_PlayVideo : MonoBehaviour {

    public float stare_time = 0f; // timer 
    public bool grabbed = false;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        stare_time = stare_time + Time.deltaTime;

        if (stare_time >= 2f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            PlayVideo();
        }
	}

    public void ResetStareTime()
    {
        stare_time = 0f;
    }

    public void PlayVideo()
    {
        Debug.Log("play video");
        grabbed = true;
        GvrVideoPlayerTexture x = this.GetComponent<GvrVideoPlayerTexture>();
        x.Play();
    }
}
