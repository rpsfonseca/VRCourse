using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredPaiting : MonoBehaviour {

    public float shredSpeed = 0.5f;
    public float shredRange = 0.5f;
    public bool canShred = false;

    public Transform parent;

    private void Start()
    {
        parent = this.GetComponentInParent<Transform>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            canShred = true;
        }

        if (canShred)
        {
            Shred();
        }

	}

    public void Shred()
    {
        float py = transform.position.y;
        transform.Translate(Vector3.down * shredSpeed * Time.deltaTime, Space.World);
        parent.Translate(Vector3.down * shredSpeed * Time.deltaTime, Space.World);
    }


    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision enter");
        canShred = false;
        Destroy(this.GetComponentInChildren<GameObject>());
    }

}
