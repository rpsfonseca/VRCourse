using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadAuctionRoom : MonoBehaviour {

    Scene Scene;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        Scene = SceneManager.GetActiveScene();

        if (other.CompareTag("Player"))
        {
            if(Scene.name.Equals("0 - Art Gallery"))
                LevelChanger.FadeToLevel(2);
            //Application.LoadLevel("2 - AuctionRoom");
            else
                Application.LoadLevel("0 - Art Gallery");
            
        }
        
    }
}
