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
                Application.LoadLevel("3 - VanGogh3D");
            else
                Application.LoadLevel("0 - Art Gallery");

        }
    }

}
