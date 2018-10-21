using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaze : MonoBehaviour
{
    public List<ParticleSystem> particleSystems;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartBlazing()
    {
        for (int i = 0; i < particleSystems.Count; i++)
        {
            particleSystems[i].Play();
        }
    }

    public void StopBlazing()
    {
        for (int i = 0; i < particleSystems.Count; i++)
        {
            particleSystems[i].Stop();
        }
    }
}
