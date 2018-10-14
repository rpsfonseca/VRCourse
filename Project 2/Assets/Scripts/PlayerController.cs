using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public const float MAX_SPEED = 5.0f;
    private const float FALL_LIMIT = -12575.0f;

    private bool walking = false;
    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
        spawnPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (walking)
        {
            transform.position += Camera.main.transform.forward * MAX_SPEED * Time.deltaTime;
        }

        if(transform.position.y < FALL_LIMIT)
        {
            transform.position = spawnPoint;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if(Physics.Raycast (ray, out hit))
        {
            if (hit.collider.name.Contains("Floor") )
            {
                walking = false;
            }
            else
                walking = true;
        }

    }
}
