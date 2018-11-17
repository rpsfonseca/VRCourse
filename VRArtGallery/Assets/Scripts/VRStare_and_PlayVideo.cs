using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_and_PlayVideo : MonoBehaviour {

    public float stare_time = 0f; // timer 
    public bool playing = false;
    public Light light;

    UnityEngine.Video.VideoPlayer videoPlayer;
    
	// Use this for initialization
	void Start()
    {
        videoPlayer = this.transform.GetComponent<UnityEngine.Video.VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update()
    {
        stare_time = stare_time + Time.deltaTime;

        Debug.Log(light.intensity);
        if (stare_time >= 2f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            PlayVideo();
        }

        if (playing && light.intensity > 0)
        {
            light.intensity =- 0.0000000001f;
        }
        Debug.Log(playing);
       
    }

    public void ResetStareTime()
    {
        videoPlayer.Pause();
        light.intensity = 1;
        playing = false;
        stare_time = 0f;
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
        playing = true;
    }

}
