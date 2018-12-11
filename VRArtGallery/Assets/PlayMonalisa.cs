using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMonalisa : MonoBehaviour {


    public UnityEngine.Video.VideoPlayer videoPlayer;
    GameObject painting;
    MeshRenderer mesh;

    void Start () {

        painting = this.GetComponentInChildren<GameObject>();
        mesh = painting.GetComponent<MeshRenderer>();
        videoPlayer = this.GetComponent<UnityEngine.Video.VideoPlayer>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mesh.enabled = false;
            videoPlayer.enabled = true;
            videoPlayer.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mesh.enabled = true;
            videoPlayer.enabled = false;
        }
    }

}
