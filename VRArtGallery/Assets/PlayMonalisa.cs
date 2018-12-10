using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMonalisa : MonoBehaviour {


    public UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject painting;

    void Start () {

        painting = this.GetComponentInChildren<GameObject>();
        videoPlayer = this.GetComponent<UnityEngine.Video.VideoPlayer>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            videoPlayer.enabled = true;
            videoPlayer.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoPlayer.enabled = false;
        }
    }

}
