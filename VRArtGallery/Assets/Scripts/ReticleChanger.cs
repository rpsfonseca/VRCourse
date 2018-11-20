using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleChanger : MonoBehaviour {

    public GameObject reticleIn;
    public GameObject reticleOut;

	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;

        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward));
            if (hit.transform.gameObject.tag.Equals("Art"))
            {
                //Debug.Log("hit art");
                //reticleIn.GetComponent<Renderer>().enabled = true;
                //reticleOut.GetComponent<Renderer>().enabled = false;

                InteractionManager.SetCurrentInteractable(hit.transform.GetComponent<Interactable>());
            }
            else
            {
                //Debug.Log("no hit art");
                //reticleIn.GetComponent<Renderer>().enabled = false;
                //reticleOut.GetComponent<Renderer>().enabled = true;

                if (InteractionManager.currentInteractable != null)
                {
                    InteractionManager.RemoveCurrentInteractable();
                }
            }
        }

	}
}
