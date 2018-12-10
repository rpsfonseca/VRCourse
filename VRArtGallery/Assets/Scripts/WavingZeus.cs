using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]
public class WavingZeus : Interactable
{
    public Animator animator;
    public AudioSource welcome;
    
    public override void StartInteraction()
    {
        animator.SetTrigger("wave");

        welcome = GetComponent<AudioSource>();
        welcome.Play(0);
        Debug.Log("started");
    }

    public override void Interaction()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("wave");
        }
    }

    public override void EndInteraction()
    {
        /*welcome.Pause();
        Debug.Log("Pause: " + welcome.time);*/
    }
}
