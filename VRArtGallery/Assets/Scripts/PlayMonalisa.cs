using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMonalisa : MonoBehaviour {


    public UnityEngine.Video.VideoPlayer videoPlayer;
    MeshRenderer[] meshes; 

    void Start () {
        meshes = this.GetComponentsInChildren<MeshRenderer>();
        videoPlayer = this.GetComponent<UnityEngine.Video.VideoPlayer>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshes[0].enabled = true;
            videoPlayer.enabled = true;
            videoPlayer.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshes[0].enabled = false;
            videoPlayer.enabled = false;
        }
    }

}
