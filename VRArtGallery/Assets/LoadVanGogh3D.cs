using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVanGogh3D : MonoBehaviour {

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
            if (Scene.name.Equals("0 - Art Gallery"))
                LevelChanger.FadeToLevel(3);
            else
                LevelChanger.FadeToLevel(0);

            //LevelChanger.FadeToLevel(3);
            //Application.LoadLevel("2 - AuctionRoom");
            /*else
            {

                LevelChanger.FadeToLevel(0);*/

         }
    }

}
