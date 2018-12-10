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
        animator.SetBool("shouldWave", true);

        welcome = GetComponent<AudioSource>();
        welcome.Play(0);
        Debug.Log("started");
    }

    public override void EndInteraction()
    {
        animator.SetBool("shouldWave", false);

        welcome.Pause();
        Debug.Log("Pause: " + welcome.time);
    }
}
