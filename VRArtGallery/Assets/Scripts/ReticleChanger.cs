using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleChanger : MonoBehaviour {

    public GameObject reticleIn;
    public GameObject reticleOut;

    public GameObject canvas;

	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;

        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit, 15.0f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward));
            if (hit.transform.gameObject.tag.Equals("Art") && InteractionManager.currentInteractable == null)
            {
                Debug.Log("hit art: " + hit.transform.GetComponent<Interactable>());
                reticleIn.GetComponent<Renderer>().enabled = true;
                reticleOut.GetComponent<Renderer>().enabled = false;

                InteractionManager.SetCurrentInteractable(hit.transform.GetComponent<Interactable>());

                if (canvas && !canvas.activeInHierarchy)
                {
                    canvas.SetActive(true);
                }
            }
            else if (!hit.transform.gameObject.tag.Equals("Art"))
            {
                Debug.Log("no hit art");
                reticleIn.GetComponent<Renderer>().enabled = false;
                reticleOut.GetComponent<Renderer>().enabled = true;

                if (InteractionManager.currentInteractable != null)
                {
                    if (canvas && canvas.activeInHierarchy)
                    {
                        canvas.SetActive(false);
                    }
                    InteractionManager.RemoveCurrentInteractable();
                }
            }
        }
        else
        {

            Debug.Log("not hitting anything");
            if (InteractionManager.currentInteractable != null)
            {
                if (canvas && canvas.activeInHierarchy)
                {
                    canvas.SetActive(false);
                }
                InteractionManager.RemoveCurrentInteractable();
            } 
        }

	}
}
