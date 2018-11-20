using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanGoghAnimatedPainting : Interactable
{
    public float stare_time = 0f; // timer 
    public bool playing = false;
    public Light light;

    public UnityEngine.Video.VideoPlayer videoPlayer;
    
    public override void StartInteraction()
    {
        stare_time = 0f;
        //videoPlayer = this.transform.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    public override void Interaction()
    {
        stare_time = stare_time + Time.deltaTime;

        //Debug.Log(light.intensity);
        if (!playing && stare_time >= 2f)
        {
            PlayVideo();
        }

        if (playing && light.intensity > 0)
        {
            light.intensity = -0.0000000001f;
        }
        //Debug.Log(playing);

    }

    public void ResetStareTime()
    {
        videoPlayer.Stop();
        light.intensity = 1;
        playing = false;
        stare_time = 0f;
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
        playing = true;
    }

    public override void EndInteraction()
    {
        ResetStareTime();
    }
}
