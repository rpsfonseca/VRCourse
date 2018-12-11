using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredPaiting : MonoBehaviour {

    public float shredSpeed = 0.5f;
    public float shredRange = 0.5f;

    private bool shred = false;
    private bool hasShreded = false;
    private bool isShreding = false;

    public Transform parent;

    GameObject childPaiting;
    MeshRenderer mesh;
    MeshRenderer[] childMesh;
    AudioSource audio;

    private void Start()
    {
        mesh = this.GetComponent<MeshRenderer>();
        childMesh = this.GetComponentsInChildren<MeshRenderer>();
        parent = this.GetComponentInParent<Transform>();
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.JoystickButton12) || Input.GetKey(KeyCode.C))
        {
            Debug.Log("C pressed");

            if (!isShreding)
            {
                shred = true;
                audio.Play();
            }
        }

        if (shred && !hasShreded)
        {
            isShreding = true;
            Shred();
        }

	}

    public void Shred()
    {
        float py = transform.position.y;
        transform.Translate(Vector3.down * shredSpeed * Time.deltaTime, Space.World);
        parent.Translate(Vector3.down * shredSpeed * Time.deltaTime, Space.World);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Frame"))
        {
            shred = false;
            hasShreded = true;
            childMesh[0].enabled = true;
            childMesh[1].enabled = false;
            audio.enabled = false;
        }
    }
}
